using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.HttpOverrides;
using NLog.Extensions.Logging;
using System.Text;
using NLog.Web;
using System.IO;
using Swashbuckle.AspNetCore.Swagger;

namespace CoreSignalR.SignalR
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            if(File.Exists("config/nlog.config"))
            {
                env.ConfigureNLog("config/nlog.config");
            }
            else if(File.Exists("wwwroot/config/nlog.config"))
            {
                env.ConfigureNLog("wwwroot/config/nlog.config");
            }
            else
            {
                //找不到日志的配置文件。直接不载入。
            }
             
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                                 .AllowAnyMethod()
                                                                  .AllowAnyHeader()
                                                                  .AllowCredentials()));
            // Add framework services.
            services.AddMvc();
            services.AddSignalR(options =>
            {
                options.Transports.EnabledTransports = Microsoft.AspNetCore.SignalR.TransportType.All;
                options.Hubs.EnableDetailedErrors = true;
                options.Transports.DisconnectTimeout = TimeSpan.FromSeconds(6);//超时时间
                options.Transports.TransportConnectTimeout = TimeSpan.FromSeconds(6);//连接超时时间
                //options.Transports.KeepAlive = TimeSpan.FromSeconds(3);//保持连接的心跳时间
            });


            services.AddSwaggerGen(a =>
            {
                a.SwaggerDoc("v1", new Info
                {
                    Title = "SignalrAPI",
                    Version = "v1",
                    Description ="为MessageHubs消息服务提供API接口调用",
                    TermsOfService ="PFKJ",
                    Contact = new Contact { Name="LeeSinRyuu_PFKJ"},
                  
                });

            });



        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//中文支持
            app.UseCors("AllowAll");
            loggerFactory.AddConsole(); //设置LOG的触发最小级别为Warnning 系统自带infomation全部不记录。
            loggerFactory.AddDebug();//添加LOG支持
            loggerFactory.AddNLog(); //本地的LOG记录。
            app.AddNLogWeb();

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto             

            }); //获取IP地址 HttpOverrides:1.0.0
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();


            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseWebSockets();//加入Websocket和SignalR支持
            app.UseSignalR();
             
            
            


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseMvcWithDefaultRoute();

            app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "DemoAPI V1");
            //});
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SignalrAPI V1");
               
            });
        }

        
    }
}

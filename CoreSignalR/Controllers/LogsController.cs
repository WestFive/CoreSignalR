using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data.Common;
using System.Net;
using Data.Model;

namespace CoreSignalRR.Controllers
{
    [Produces("application/json")]
    [Route("api/Logs")]
    public class LogsController : Controller
    {

        // GET: api/Logs
        [HttpGet]
        public object  Get()
        {
            try
            {
                Loger.FilePath = "wwwroot/Log";
                List<string> list = Loger.ReadFromLogTxt(DateTime.Now,0);
                var value = JsonHelper.SerializeObject(Loger.ReadFromLogTxt(DateTime.Now,0));
                if (list.Count == 0)
                {
                    return GetJson(HttpStatusCode.NotFound, value);
                }

                return GetJson(HttpStatusCode.OK, value);
            }
            catch (Exception ex)
            {
                return GetJson(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        [HttpPost("{days}")]
        public object Post([FromForm]LogResponse res)
        {
            try
            {
                //if (time==null)
                //{
                //    //time =  DateTime.Now;
                //}
                
                DateTime datetime = Convert.ToDateTime(res.time);
                Loger.FilePath = "wwwroot/Log";
                List<string> list = Loger.ReadFromLogTxt(datetime, res.days);
                var value = JsonHelper.SerializeObject(Loger.ReadFromLogTxt(datetime, res.days));
                if (list.Count == 0)
                {
                    return GetJson(HttpStatusCode.NotFound, value);
                }

                return GetJson(HttpStatusCode.OK, value);
            }
            catch(Exception ex)
            {
                return GetJson(HttpStatusCode.InternalServerError, ex.ToString());
            }


        }


        [NonAction]
        public object GetJson(HttpStatusCode code, object obj)
        {

            if (code != HttpStatusCode.OK)
            {
                return Json(new
                {
                    StatusCode = code,
                    error = obj
                });
            }

            return Json(new
            {
                StatusCode = code,
                data = obj
            });

        }

        //// GET: api/Logs/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Logs
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Logs/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

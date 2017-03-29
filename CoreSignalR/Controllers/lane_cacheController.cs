using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreSignalRR.signalr;
using Data.Common;
using Data.Model;
using System.Net;

namespace CoreSiganl.Controllers
{
    [Route("api/[controller]")]
    public class lane_cacheController : Controller
    {


        // GET api/Clients
        [HttpGet]
        public object Get()
        {
            //return JsonHelper.SerializeObject(MessageHub.StatusList);
            try
            {
                var value = MessageHub.StatusList;
                if (value.Count == 0)
                {
                    return GetJson(HttpStatusCode.NoContent, "无内容");
                }
                return GetJson(HttpStatusCode.OK, value);
            }
            catch (Exception ex)
            {
                return GetJson(HttpStatusCode.InternalServerError, ex.ToString());
            }
        }

        [HttpPost("{lane_code}")]
        public Object Post([FromQuery]string lane_code, [FromBody]Pf_Message_Obj message_obj)
        {

            try
            {



                lock (MessageHub.StatusList)
                {
                    if (MessageHub.StatusList.Count(x => x.lane_code == message_obj.lane_code) > 0)
                    {
                        MessageHub.StatusList[MessageHub.StatusList.FindIndex(x => x.lane_code == message_obj.lane_code)] = message_obj;//更新content

                        return GetJson(HttpStatusCode.OK, "修改成功");

                    }
                    else
                    {
                        return GetJson(HttpStatusCode.NotFound, "没有找到该条数据，无法修改");
                    }
                }


            }



            catch (Exception ex)
            {
                Loger.AddErrorText("API修改车道数据失败", ex);
                return GetJson(HttpStatusCode.InternalServerError, ex.ToString());

            }
        }


        [HttpOptions]
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


    }
}

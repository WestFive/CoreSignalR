using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    /// <summary>
    /// JSON总体消息对象
    /// </summary>
    /// 
    public class Pf_Message_Obj
    {
        /// <summary>
        /// 消息类型 指令或状态或作业
        /// </summary>
        public string message_type { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public object message_content { get; set; }

    }


    public class pf_JobContet_Obj
    {
        public string guid { get; set; }

        public string lane_status { get; set; }
    }
        


    /// <summary>
    /// 指令消息对象
    /// </summary>
    public class pf_MessageActionContext_Obj
    {
        public string lane_code { get; set; }
        public string connection_id { get; set; }

        public DateTime send_time { get; set; }

        public string action_code { get; set; }

        public string action_content { get; set; }


    }

    /// <summary>
    /// 车道消息对象
    /// </summary>
    public class pf_MessageStatusContext_Obj
    {
        /// <summary>
        /// 车道ID
        /// </summary>
        public string lane_code { get; set; }
        /// <summary>
        /// 地区编号
        /// </summary>
        public string country_code { get; set; }
        /// <summary>
        /// 区域编号
        /// </summary>
        public string city_code { get; set; }
        /// <summary>
        /// 场站编号
        /// </summary>
        public string terminal_code { get; set; }
        /// <summary>
        /// 车道号
        /// </summary>
        public string lane_name { get; set; }
        /// <summary>
        /// 车道类型
        /// </summary>
        public string direction { get; set; }
        /// <summary>
        /// 连接ID
        /// </summary>
        public string connection_id { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string update_time { get; set; }
        /// <summary>
        ///  车道状态（对象）
        /// </summary>
        public string lane_status { get; set; }



    }


}

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

    public class Pf_Message_lane_Object
    {
        public string lane_code { get; set; }
        public string send_time { get; set; }
        public object lane { get; set; }
    }

    public class Pf_Messge_Queue_Object
    {
        public string lane_code { get; set; }
        public string queue_id { get; set; }

        public string action { get; set; }
        public string create_time { get; set; }
        public string send_time { get; set; }
        public object queue { get; set; }

    }

    public class pf_Message_Directive
    {
        public string directive_id { get; set; }
        public string lane_code { get; set; }
        public string lane_name { get; set; }
        public string directive_code { get; set; }
        public string[] parameters { get; set; }
        public string send_time { get; set; }
    }






}

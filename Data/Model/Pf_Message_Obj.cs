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
        /// 车道索引ID
        /// </summary>
        public string lane_code { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string message_content { get; set; }

    }




  

}

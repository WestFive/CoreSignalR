using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public struct pf_Containers_Struct
    {
        /// <summary>
        /// 位置
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 集装箱号
        /// </summary>
        public string container_no { get; set; }
        /// <summary>
        /// OCR识别集装箱号
        /// </summary>
        public string ocr_container_no { get; set; }

        /// <summary>
        /// ISO码
        /// </summary>
        public string iso_code { get; set; }

        /// <summary>
        /// 作业类型内容
        /// </summary>
        public string job_type { get; set; }
        /// <summary>
        /// 残损信息数组 
        /// </summary>
        public pf_Damage_Struct[] damages { get;set;}
        
           
        /// <summary>
        /// 发送邮件。
        /// </summary>
        public string send_email { get; set; }
    }
}

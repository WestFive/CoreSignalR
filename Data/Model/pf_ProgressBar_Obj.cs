using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Model
{
    public class pf_ProgressBar_Obj
    {

        /// <summary>
        /// 与进度条“车道就绪”关联
        /// </summary>
        public bool lane_ready { get; set; }
        //public string lane_ready_value
        //{
        //    get { return lane_ready == true ? "lane_ready" : "null"; }
        //    set { lane_ready_value = value; }
            
        //}
        /// <summary>
        /// 与进度条“感应来车”关联，以及车斗图标关联
        /// </summary>
        public bool has_truck { get; set; }
        /// <summary>
        /// 与进度条“车牌读卡”关联
        /// </summary>
        public bool truck_rfid { get; set; }
        /// <summary>
        /// 与进度条“车牌识别”关连
        /// </summary>
        public bool truck_ocr { get; set; }
        /// <summary>
        ///  与进度条“箱号识别”关联
        /// </summary>
        public bool container_ocr { get; set; }
        /// <summary>
        /// \\与进度条“司机读卡”关联
        /// </summary>
        public bool read_ic_card { get; set; }
        /// <summary>
        ///   \\与进度条“箱体验残”关联
        /// </summary>
        public bool damage_check { get; set; }
        /// <summary>
        /// \\与进度条“提交TOS”关联
        /// </summary>
        public bool submit_to_tos { get; set; }
        /// <summary>
        ///  \\与进度条“TOS反馈”关联
        /// </summary>
        public bool reply_from_tos { get; set; }
        /// <summary>
        /// \\与进度条“打印小票”关联
        /// </summary>
        public bool print_recipt { get; set; }
        /// <summary>
        ///    \\与进度条“抬杆放行”关联
        /// </summary>
        public bool lift_barrier { get; set; }

    }
}

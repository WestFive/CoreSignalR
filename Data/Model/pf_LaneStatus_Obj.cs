using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class pf_LaneStatus_Obj
    {

        /// <summary>
        /// 是否有车
        /// </summary>
        public bool has_truck { get; set; }
        /// <summary>
        /// 锁定状态
        /// </summary>
        public bool lock_status { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string user { get; set; }
        /// <summary>
        /// 车道状态
        /// </summary>
        public string lane_type { get; set; }
        /// <summary>
        /// LED显示文本
        /// </summary>
        public string led_display { get; set; }
        /// <summary>
        /// 作业开始时间
        /// </summary>
        public DateTime start_time { get; set; }
        /// <summary>
        /// 作业结束时间 指放行时间
        /// </summary>
        public DateTime end_time { get; set; }
        /// <summary>
        /// 车牌号，第一次赋值与OcrTruckNo一致，如果识别错误，用户可修改
        /// </summary>
        public string trunk_no { get; set; }
        /// <summary>
        /// OCR识别车牌号，第一次赋值后不再修改，用于日后在后台数据库与TruckNo进行比较，计算车牌识别率
        /// </summary>
        public string ocr_trunk_no { get; set; }
        /// <summary>
        /// rfid电子车牌号
        /// </summary>
        public string rfid_trunk_no { get; set; }
        /// <summary>
        /// 地磅重量
        /// </summary>
        public float weight_bridge { get; set; }
        /// <summary>
        /// 起落杆状态，down为落杆，up为起杆，与图标关联
        /// </summary>
        public string barrier { get; set; }
        /// <summary>
        /// IC卡读卡号
        /// </summary>
        public string ic_card_no { get; set; }


        //public pf_ProgressBar_Obj progress_bar { get; set; }
        /// <summary>
        /// 进度状态 
        /// </summary>
        public string[] progress_bar { get; set; }
        /// <summary>
        /// 验残次数
        /// </summary>
        public int damage_checks { get; set; }
        /// <summary>
        /// 残损记录数
        /// </summary>
        public int damage_counts { get; set; }
        /// <summary>
        /// 提交次数
        /// </summary>
        public int submit_counts { get; set; }
        /// <summary>
        /// 车头图片URL
        /// </summary>
        public string truck_pic_url { get; set; }

        /// <summary>
        /// 车牌图片URL
        /// </summary>
        public string truck_crop_pic_url { get; set; }
        /// <summary>
        /// 前顶图片URL
        /// </summary>
        public string front_top_pic_url { get; set; }
        /// <summary>
        /// 后顶图片URL
        /// </summary>
        public string back_top_pic_url { get; set; }
        /// <summary>
        /// 左前图片URL
        /// </summary>
        public string left_front_pic_url { get; set; }
        /// <summary>
        /// 左后图片URL
        /// </summary>
        public string left_back_pic_url { get; set; }
        /// <summary>
        /// 右前图片URL
        /// </summary>
        public string right_front_pic_url { get; set; }
        /// <summary>
        /// 右后图片URL
        /// </summary>
        public string right_back_pic_url { get; set; }
        /// <summary>
        /// 左面箱体拼接图片URL
        /// </summary>
        public string left_damage_pic_url { get; set; }
        /// <summary>
        /// 右面箱体拼接图片URL
        /// </summary>
        public string right_damage_pic_url { get; set; }
        /// <summary>
        /// 顶面箱体拼接图片URL
        /// </summary>
        public string top_damage_pic_url { get; set; }

        public pf_Containers_Struct[] containers { get; set; }



    }
}

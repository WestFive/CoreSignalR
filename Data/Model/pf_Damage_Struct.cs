using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
   public struct pf_Damage_Struct
    {
        /// <summary>
        /// 残损面
        /// </summary>
        public string side { get; set; }

        /// <summary>
        /// 残损代码
        /// </summary>
        public string damage_code { get; set; }

        /// <summary>
        /// 残损等级
        /// </summary>
        public string damage_grade { get; set; }

        /// <summary>
        /// REMARK
        /// </summary>
        public string remark { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOS_WF.Models
{
    class Schedule
    {
        public int id_Sche { get; set; }
        public int id_Ses { get; set; }
        public int id_F { get; set; }
        public int id_C { get; set; }
        public int id_R { get; set; }
        public TimeSpan StartTime { get; set; }
        public int Status { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Sche_Date { get; set; }
        public string vipSeat { get; set; }
        public int normalPrice { get; set; }
        public int vipPrice { get; set; }
    }
}

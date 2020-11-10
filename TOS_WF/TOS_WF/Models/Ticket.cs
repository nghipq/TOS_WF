using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOS_WF.Models
{
    class Ticket
    {
        //public int id_T { get; set; }
        //public int id_Sche { get; set; }
        //public int id_S { get; set; }
        //public int Status { get; set; }
        public int id_T { get; set; }
        public int id_Sche { get; set; }
        public string T_Name { get; set; }
        public int T_Price { get; set; }
        public int id_Ses { get; set; }
        public int id_F { get; set; }
        public int Status { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Sche_Date { get; set; }
        public int id_C { get; set; }
        public int id_R { get; set; }
        public int R_SeatNumber { get; set; }
        public int R_Size { get; set; }
        public int R_Type { get; set; }
        public int R_Row { get; set; }
        public int R_Col { get; set; }
        public string R_Name { get; set; }
    }
}

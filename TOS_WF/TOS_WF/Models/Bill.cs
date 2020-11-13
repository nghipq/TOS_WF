using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOS_WF.Models
{
    class Bill
    {
        public int id_B { get; set; }
        public int id_Cus { get; set; }
        public int id_Staff { get; set; }
        public DateTime DateBuy { get; set; }
        public string Total { get; set; }
        public bool Status { get; set; }
    }
}

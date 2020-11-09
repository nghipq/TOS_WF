using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOS_WF.Models
{
    class Graphics
    {
        public int id_G { get; set; }
        public int id_F { get; set; }
        public int G_Type { get; set; }
        public DateTime DateUpdate { get; set; }
        public String Path { get; set; }
        public int Status { get; set; }
    }
}

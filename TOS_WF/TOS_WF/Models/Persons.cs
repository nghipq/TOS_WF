using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOS_WF.Models
{
    class Persons
    {
        public int id_Per { get; set; }
        public String Per_Name { get; set; }
        public int id_N { get; set; }
        public int id_Role { get; set; }
        public int Gender { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Birthday { get; set; }
        public String Description { get; set; }
        public bool Status { get; set; }
    }
}

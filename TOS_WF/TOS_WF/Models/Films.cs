using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOS_WF.Models
{
    class Films
    {
        public int id_F { get; set; }
        public String F_Name { get; set; }
        public int id_P { get; set; }

        public string P_Name { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ReleaseDate { get; set; }
        public Double Rating { get; set; }
        public int LimitAge { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime AirDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime EndDate { get; set; }
        public String Description { get; set; }
        public int Status { get; set; }
        public string Poster { get; set; }
        [NotMapped]
        public Image Picture
        {
            get
            {
                string path = "../../images/poster/" + Poster;
                if (!string.IsNullOrEmpty(path)) {
                    if (File.Exists(path))
                        return Image.FromFile(path);

                }
                return null;
            }
        }
        public int F_Time { get; set; }
        public string F_Trailer { get; set; }
        public List<Persons> Actors { get; set; }
        public List<Persons> Directors { get; set; }
        public List<Categories> Categories { get; set; }
        public List<Schedule> Schedules { get; set; }
       
    }
}

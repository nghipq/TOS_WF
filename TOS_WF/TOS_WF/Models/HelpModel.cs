using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOS_WF.Models
{
     public class HelpModel
    {
        public int H_Name { get; set; }
        public Image PictureHelp
        {
            get
            {
                string path = "../../images/help/" + H_Name+".PNG";
                if (!string.IsNullOrEmpty(path))
                {
                    if (File.Exists(path))
                        return Image.FromFile(path);

                }
                return null;
            }
        }
    }
    public class HelpList : List<HelpModel>
    {
        public HelpList()
        {
            InitializeList();
        }
        void InitializeList()
        {
            AddRange(new HelpModel[] {
                new HelpModel() {
                   H_Name=1,
                },
                new HelpModel() {
                   H_Name=2,
                },
                new HelpModel() {
                   H_Name=3,
                },
                new HelpModel() {
                   H_Name=4,
                },
                 new HelpModel() {
                   H_Name=5,
                },
                  new HelpModel() {
                   H_Name=6,
                },
                   new HelpModel() {
                   H_Name=7,
                },
            }); ;
        }
    }
}

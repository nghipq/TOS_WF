using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOS_WF.Models
{
    class Help
    {
        public string H_Name { get; set; }
        public Image PictureHelp
        {
            get
            {
                string path = "../../images/poster/" + H_Name;
                if (!string.IsNullOrEmpty(path))
                {
                    if (File.Exists(path))
                        return Image.FromFile(path);

                }
                return null;
            }
        }
    }
}

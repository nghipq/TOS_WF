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
}

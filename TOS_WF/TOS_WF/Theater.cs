using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOS_WF
{
    public partial class Theater : DevExpress.XtraEditors.XtraForm
    {
        public Theater()
        {
            InitializeComponent();
            frmRoom r = new frmRoom();
           
            r.Visible = true;

        }
    }
}

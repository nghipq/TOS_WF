using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TOS_WF.Frames
{
    public partial class ScheduleList : DevExpress.XtraEditors.XtraForm
    {
        public ScheduleList()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
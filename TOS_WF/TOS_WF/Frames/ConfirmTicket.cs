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
    public partial class ConfirmTicket : DevExpress.XtraEditors.XtraForm
    {
        public ConfirmTicket()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }
        private void ConfirmTicket_Load(object sender, EventArgs e)
        {

        }

        private void txtFname_Click(object sender, EventArgs e)
        {

        }
    }
}
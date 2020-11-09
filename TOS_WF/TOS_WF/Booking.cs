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
using TOS_WF.Frames;

namespace TOS_WF
{
    public partial class Booking : DevExpress.XtraEditors.XtraForm
    {
        public Ticket pnlTicket;

        public Booking()
        {
            InitializeComponent();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.Fixed3D;
            //this.WindowState = FormWindowState.Maximized;

            pnlTicket = new Ticket();
            pnlTicket.MdiParent = this;
            pnlTicket.Show();
        }
    }
}
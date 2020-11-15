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
using TOS_WF.DAO;

namespace TOS_WF.Frames
{
    public partial class frmTicket : DevExpress.XtraEditors.XtraForm
    {
        public string ticket_seat { get; set; }
        public string ticket_id { get; set; }
        public int T_Price { get; set; }
        public frmTicket(string ticket_seat, string ticket_id)
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            lblSeat.Text = ticket_seat;//hien thi ten ghe
            lblTotal.Text = new TicketDAO().calculateTotalPrice(ticket_id) + " VND";
            this.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlContent.BackColor = Color.FromArgb(10, Color.White);
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
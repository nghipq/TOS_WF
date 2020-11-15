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
using TOS_WF.Models;
using TOS_WF.DAO;
using DevExpress.XtraPrinting.Native.Lines;

namespace TOS_WF.Frames
{
    public partial class ConfirmTicket : DevExpress.XtraEditors.XtraForm
    {
        public string ticket_seat { get; set; }
        public string ticket_id { get; set; }

        public int T_Price { get; set; }

        public String F_Name { get; set; }
        public int id_F { get; set; }
        public ConfirmTicket(string ticket_seat,string ticket_id)
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            lblSeat.Text = ticket_seat;//hien thi ten ghe
            //tinh tong tien
            lblTotal.Text= new TicketDAO().calculateTotalPrice(ticket_id) + " VND";
            //lblCinema.Text = new FilmDAO().getFilmById(id_F).ToString();
            this.panelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            panelControl2.BackColor = Color.FromArgb(10, Color.White);
        }
        private void ConfirmTicket_Load(object sender, EventArgs e)
        {

        }

        private void txtFname_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        //private void btnConfirm_Click(object sender, EventArgs e)
        //{
        //    lblTotal.Text = new TicketDAO().calculateTotalPrice(ticket_id) + " VND";
        //    Console.WriteLine(lblTotal.Text);
        //    //BillDAO bill = new BillDAO();
        //    //bill.CreateBill(1, 1, lblTotal.Text);
        //    //this.Visible = false;
        //    //int getvalue = bill.getMaxIdBill();
        //    //BillDetailDAO bd = new BillDetailDAO();
        //    //bd.CreateBillDetail(1, getvalue);
        //    //this.Visible = false;

        //}
    }
}
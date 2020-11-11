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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            BillDAO bill = new BillDAO();
            bill.CreateBill(1, 1, 0);
            this.Visible = false;
            int getvalue = bill.getMaxIdBill();
            BillDetailDAO bd = new BillDetailDAO();
            bd.CreateBillDetail(1, getvalue);
            this.Visible = false;
            
        }
    }
}
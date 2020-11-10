﻿using System;
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
        //public Ticket pnlTicket;
        public ConfirmTicket pnlConTicket;
        public Ticket pnlTicket;
        public string cinemaName = "Vincom";
        public string schedule = "8.00 - 11.00";
        public string room = "3";
        public string seat = "A1 A2 A3";
        public string total = "400000";

        public Booking()
        {

            InitializeComponent();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.Fixed3D;
            //this.WindowState = FormWindowState.Maximized;

            pnlConTicket = new ConfirmTicket();
            pnlConTicket.MdiParent = this;
            pnlConTicket.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);
            pnlConTicket.lblCinema.Text = cinemaName;
            pnlConTicket.lblSchedule.Text = schedule;
            pnlConTicket.lblRoom.Text = room;
            pnlConTicket.lblSeat.Text = seat;
            pnlConTicket.lblTotal.Text = total;
            pnlConTicket.Show();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            pnlTicket = new Ticket();
            pnlTicket.MdiParent = this;
            pnlTicket.Show();
        }
    }
}
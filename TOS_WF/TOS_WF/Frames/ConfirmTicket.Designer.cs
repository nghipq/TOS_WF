namespace TOS_WF.Frames
{
    partial class ConfirmTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblBillId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(90, 263);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(114, 30);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Tên rạp:";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(90, 409);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(173, 30);
            this.lbl3.TabIndex = 15;
            this.lbl3.Text = "Phòng chiếu:";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat.Location = new System.Drawing.Point(406, 486);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(0, 25);
            this.lblSeat.TabIndex = 21;
            this.lblSeat.Click += new System.EventHandler(this.lblSeat_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(406, 560);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 27);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirm.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(460, 647);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(334, 59);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "Thanh Toán";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(89, 647);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(334, 55);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lblBillId);
            this.panelControl2.Controls.Add(this.lblFname);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnConfirm);
            this.panelControl2.Controls.Add(this.lblTotal);
            this.panelControl2.Controls.Add(this.lblSeat);
            this.panelControl2.Controls.Add(this.lblRoom);
            this.panelControl2.Controls.Add(this.lblSchedule);
            this.panelControl2.Controls.Add(this.lblCinema);
            this.panelControl2.Controls.Add(this.lbl5);
            this.panelControl2.Controls.Add(this.lbl4);
            this.panelControl2.Controls.Add(this.lbl3);
            this.panelControl2.Controls.Add(this.lbl2);
            this.panelControl2.Controls.Add(this.lbl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1156, 782);
            this.panelControl2.TabIndex = 1;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(90, 334);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(205, 30);
            this.lbl2.TabIndex = 14;
            this.lbl2.Text = "Xuất chiếu:";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(90, 482);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(133, 30);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "Số ghế:";
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(90, 558);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(100, 30);
            this.lbl5.TabIndex = 17;
            this.lbl5.Text = "Tổng:";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.Location = new System.Drawing.Point(406, 263);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(0, 25);
            this.lblCinema.TabIndex = 18;
            this.lblCinema.Click += new System.EventHandler(this.lblCinema_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(406, 338);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(0, 25);
            this.lblSchedule.TabIndex = 19;
            this.lblSchedule.Click += new System.EventHandler(this.lblSchedule_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(406, 414);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(0, 25);
            this.lblRoom.TabIndex = 20;
            this.lblRoom.Click += new System.EventHandler(this.lblRoom_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(121, 59);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(0, 63);
            this.lblFname.TabIndex = 30;
            this.lblFname.Click += new System.EventHandler(this.lblFname_Click);
            // 
            // lblBillId
            // 
            this.lblBillId.AutoSize = true;
            this.lblBillId.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillId.Location = new System.Drawing.Point(406, 190);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(0, 25);
            this.lblBillId.TabIndex = 31;
            this.lblBillId.Click += new System.EventHandler(this.lblBillId_Click);
            // 
            // ConfirmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 782);
            this.Controls.Add(this.panelControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfirmTicket";
            this.Text = "ConfirmTicket";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        public System.Windows.Forms.Label lblSeat;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Button btnConfirm;
        public System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public System.Windows.Forms.Label lblBillId;
        public System.Windows.Forms.Label lblFname;
        public System.Windows.Forms.Label lblRoom;
        public System.Windows.Forms.Label lblSchedule;
        public System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
    }
}
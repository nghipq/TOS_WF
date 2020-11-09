namespace TOS_WF.Frames
{
    partial class Ticket
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.pnlImg = new DevExpress.XtraEditors.PanelControl();
            this.pnlContent = new DevExpress.XtraEditors.PanelControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.ContentImage = ((System.Drawing.Image)(resources.GetObject("pnlImg.ContentImage")));
            this.pnlImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImg.Location = new System.Drawing.Point(0, 0);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(397, 609);
            this.pnlImg.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.textBox1);
            this.pnlContent.Controls.Add(this.lblUser);
            this.pnlContent.Controls.Add(this.lbl);
            this.pnlContent.Controls.Add(this.lblTotal);
            this.pnlContent.Controls.Add(this.lblSeat);
            this.pnlContent.Controls.Add(this.lblRoom);
            this.pnlContent.Controls.Add(this.lblSchedule);
            this.pnlContent.Controls.Add(this.lblCinema);
            this.pnlContent.Controls.Add(this.lbl5);
            this.pnlContent.Controls.Add(this.lbl4);
            this.pnlContent.Controls.Add(this.lbl3);
            this.pnlContent.Controls.Add(this.lbl2);
            this.pnlContent.Controls.Add(this.lbl1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(397, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(930, 609);
            this.pnlContent.TabIndex = 1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(82, 260);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(132, 34);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Tên rạp:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(82, 334);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(175, 34);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Xuất chiếu:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(82, 407);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(198, 34);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Phòng chiếu:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(82, 480);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(121, 34);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Số ghế:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(82, 554);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(95, 34);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Tổng:";
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.Location = new System.Drawing.Point(398, 264);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(229, 29);
            this.lblCinema.TabIndex = 6;
            this.lblCinema.Text = "Vincom Hùng Vương";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(398, 338);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(145, 29);
            this.lblSchedule.TabIndex = 7;
            this.lblSchedule.Text = "8:00 - 10:00";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(398, 411);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(26, 29);
            this.lblRoom.TabIndex = 8;
            this.lblRoom.Text = "3";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat.Location = new System.Drawing.Point(398, 484);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(141, 29);
            this.lblSeat.TabIndex = 9;
            this.lblSeat.Text = "45 46 47 48";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(398, 558);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(145, 29);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "400000 VND";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(82, 186);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(192, 34);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "Khách hàng:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(398, 190);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 29);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Xu Kai";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(88, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 77);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "abc bbs sbns sc hghg hgg bsc scasc bscasc sbcasbc shasbc";
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(TOS_WF.Models.Schedule);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 609);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlImg);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlImg;
        private DevExpress.XtraEditors.PanelControl pnlContent;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}
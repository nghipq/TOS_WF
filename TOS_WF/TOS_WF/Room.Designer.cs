﻿namespace TOS_WF
{
    partial class frmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtShowSeat = new System.Windows.Forms.TextBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pnlRoomSeat = new System.Windows.Forms.Panel();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblScreen = new System.Windows.Forms.Label();
            this.pnlSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.pnlRoomSeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtShowSeat);
            this.panel2.Controls.Add(this.pbNext);
            this.panel2.Controls.Add(this.pbBack);
            this.panel2.Location = new System.Drawing.Point(176, 544);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 53);
            this.panel2.TabIndex = 2;
            // 
            // txtShowSeat
            // 
            this.txtShowSeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtShowSeat.Enabled = false;
            this.txtShowSeat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowSeat.Location = new System.Drawing.Point(109, 11);
            this.txtShowSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShowSeat.Name = "txtShowSeat";
            this.txtShowSeat.Size = new System.Drawing.Size(668, 35);
            this.txtShowSeat.TabIndex = 2;
            this.txtShowSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbNext
            // 
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(795, 11);
            this.pbNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(57, 34);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 1;
            this.pbNext.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(14, 11);
            this.pbBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(49, 33);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 0;
            this.pbBack.TabStop = false;
            // 
            // pnlRoomSeat
            // 
            this.pnlRoomSeat.BackColor = System.Drawing.Color.White;
            this.pnlRoomSeat.Controls.Add(this.lblRoom);
            this.pnlRoomSeat.Controls.Add(this.lblScreen);
            this.pnlRoomSeat.Controls.Add(this.pnlSeat);
            this.pnlRoomSeat.Location = new System.Drawing.Point(62, 21);
            this.pnlRoomSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRoomSeat.Name = "pnlRoomSeat";
            this.pnlRoomSeat.Size = new System.Drawing.Size(1013, 506);
            this.pnlRoomSeat.TabIndex = 4;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(51, 31);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(44, 13);
            this.lblRoom.TabIndex = 6;
            this.lblRoom.Text = "lblRoom";
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.ForeColor = System.Drawing.Color.Firebrick;
            this.lblScreen.Location = new System.Drawing.Point(410, 19);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(157, 40);
            this.lblScreen.TabIndex = 5;
            this.lblScreen.Text = "SCREEN";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSeat
            // 
            this.pnlSeat.Location = new System.Drawing.Point(335, 80);
            this.pnlSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSeat.Name = "pnlSeat";
            this.pnlSeat.Size = new System.Drawing.Size(586, 401);
            this.pnlSeat.TabIndex = 0;
            // 
            // frmRoom
            // 
            this.Appearance.BackColor = System.Drawing.Color.Firebrick;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 607);
            this.Controls.Add(this.pnlRoomSeat);
            this.Controls.Add(this.panel2);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRoom";
            this.Text = "Room";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.pnlRoomSeat.ResumeLayout(false);
            this.pnlRoomSeat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtShowSeat;
        private System.Windows.Forms.Panel pnlRoomSeat;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.FlowLayoutPanel pnlSeat;
        public System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.Label lblRoom;
        public System.Windows.Forms.PictureBox pbBack;
    }
}
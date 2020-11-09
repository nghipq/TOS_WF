namespace TOS_WF
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
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.pnlRoomSeat = new System.Windows.Forms.Panel();
            this.pnlSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.lblScreen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtShowSeat = new System.Windows.Forms.TextBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pnlF_Information = new System.Windows.Forms.Panel();
            this.lblF_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.pnlRoomSeat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.pnlF_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPoster
            // 
            this.pbPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPoster.Image = ((System.Drawing.Image)(resources.GetObject("pbPoster.Image")));
            this.pbPoster.Location = new System.Drawing.Point(16, 216);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(333, 464);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 0;
            this.pbPoster.TabStop = false;
            // 
            // pnlRoomSeat
            // 
            this.pnlRoomSeat.BackColor = System.Drawing.Color.White;
            this.pnlRoomSeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRoomSeat.Controls.Add(this.pnlSeat);
            this.pnlRoomSeat.Controls.Add(this.lblScreen);
            this.pnlRoomSeat.Location = new System.Drawing.Point(463, 55);
            this.pnlRoomSeat.Name = "pnlRoomSeat";
            this.pnlRoomSeat.Size = new System.Drawing.Size(1364, 764);
            this.pnlRoomSeat.TabIndex = 1;
            // 
            // pnlSeat
            // 
            this.pnlSeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeat.Location = new System.Drawing.Point(75, 132);
            this.pnlSeat.Name = "pnlSeat";
            this.pnlSeat.Size = new System.Drawing.Size(1220, 574);
            this.pnlSeat.TabIndex = 2;
            this.pnlSeat.TabStop = true;
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.ForeColor = System.Drawing.Color.Red;
            this.lblScreen.Location = new System.Drawing.Point(607, 47);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(187, 49);
            this.lblScreen.TabIndex = 1;
            this.lblScreen.Text = "SCREEN";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtShowSeat);
            this.panel1.Controls.Add(this.pbNext);
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Location = new System.Drawing.Point(268, 871);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 82);
            this.panel1.TabIndex = 3;
            // 
            // txtShowSeat
            // 
            this.txtShowSeat.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowSeat.Location = new System.Drawing.Point(125, 11);
            this.txtShowSeat.Name = "txtShowSeat";
            this.txtShowSeat.Size = new System.Drawing.Size(1038, 57);
            this.txtShowSeat.TabIndex = 7;
            this.txtShowSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbNext
            // 
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(1204, 7);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(67, 61);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNext.TabIndex = 6;
            this.pbNext.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(22, 7);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(67, 61);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            // 
            // pnlF_Information
            // 
            this.pnlF_Information.BackColor = System.Drawing.Color.White;
            this.pnlF_Information.Controls.Add(this.lblF_Name);
            this.pnlF_Information.Controls.Add(this.pbPoster);
            this.pnlF_Information.Location = new System.Drawing.Point(84, 55);
            this.pnlF_Information.Name = "pnlF_Information";
            this.pnlF_Information.Size = new System.Drawing.Size(363, 764);
            this.pnlF_Information.TabIndex = 4;
            // 
            // lblF_Name
            // 
            this.lblF_Name.AutoSize = true;
            this.lblF_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblF_Name.ForeColor = System.Drawing.Color.Black;
            this.lblF_Name.Location = new System.Drawing.Point(29, 49);
            this.lblF_Name.Name = "lblF_Name";
            this.lblF_Name.Size = new System.Drawing.Size(320, 35);
            this.lblF_Name.TabIndex = 1;
            this.lblF_Name.Text = "NHỮNG KẺ VÔ CẢM ";
            this.lblF_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRoom
            // 
            this.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1040);
            this.Controls.Add(this.pnlF_Information);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRoomSeat);
            this.Name = "frmRoom";
            this.Text = "Room";
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.pnlRoomSeat.ResumeLayout(false);
            this.pnlRoomSeat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.pnlF_Information.ResumeLayout(false);
            this.pnlF_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Panel pnlRoomSeat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.TextBox txtShowSeat;
        private System.Windows.Forms.Panel pnlF_Information;
        private System.Windows.Forms.Label lblF_Name;
        private System.Windows.Forms.FlowLayoutPanel pnlSeat;
    }
}
namespace TOS_WF
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Header = new DevExpress.XtraEditors.PanelControl();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlBtnDate = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Appearance.BackColor = System.Drawing.Color.White;
            this.Header.Appearance.Options.UseBackColor = true;
            this.Header.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Header.ContentImage = ((System.Drawing.Image)(resources.GetObject("Header.ContentImage")));
            this.Header.Controls.Add(this.lblSec);
            this.Header.Controls.Add(this.lblEmpty);
            this.Header.Controls.Add(this.lblMinutes);
            this.Header.Controls.Add(this.btnLogout);
            this.Header.Controls.Add(this.pnlBtnDate);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1932, 105);
            this.Header.TabIndex = 0;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1788, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 40);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlBtnDate
            // 
            this.pnlBtnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtnDate.AutoSize = true;
            this.pnlBtnDate.BackColor = System.Drawing.Color.White;
            this.pnlBtnDate.Location = new System.Drawing.Point(1085, 50);
            this.pnlBtnDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBtnDate.Name = "pnlBtnDate";
            this.pnlBtnDate.Size = new System.Drawing.Size(780, 50);
            this.pnlBtnDate.TabIndex = 1;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(13, 13);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(34, 23);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "00";
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.Location = new System.Drawing.Point(43, 15);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(22, 23);
            this.lblEmpty.TabIndex = 4;
            this.lblEmpty.Text = ":";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(62, 13);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(34, 23);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "00";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1932, 543);
            this.Controls.Add(this.Header);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl Header;
        public System.Windows.Forms.FlowLayoutPanel pnlBtnDate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblMinutes;
    }
}
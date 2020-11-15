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
            this.btnLogout.Image = global::TOS_WF.Properties.Resources.logout_button;
            this.btnLogout.Location = new System.Drawing.Point(1832, 11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 32);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 543);
            this.Controls.Add(this.Header);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
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
    }
}
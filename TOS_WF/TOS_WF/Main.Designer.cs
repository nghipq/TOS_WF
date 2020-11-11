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
            this.Header.Controls.Add(this.pnlBtnDate);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(776, 85);
            this.Header.TabIndex = 0;
            // 
            // pnlBtnDate
            // 
            this.pnlBtnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtnDate.AutoSize = true;
            this.pnlBtnDate.BackColor = System.Drawing.Color.White;
            this.pnlBtnDate.Location = new System.Drawing.Point(50, 41);
            this.pnlBtnDate.Name = "pnlBtnDate";
            this.pnlBtnDate.Size = new System.Drawing.Size(669, 41);
            this.pnlBtnDate.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 441);
            this.Controls.Add(this.Header);
            this.IsMdiContainer = true;
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
    }
}
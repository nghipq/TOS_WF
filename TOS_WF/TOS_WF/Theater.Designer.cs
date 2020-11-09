namespace TOS_WF
{
    partial class Theater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theater));
            this.pnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.pnlBtnDate = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Appearance.BackColor = System.Drawing.Color.Red;
            this.pnlHeader.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.pnlHeader.Appearance.BorderColor = System.Drawing.Color.Red;
            this.pnlHeader.Appearance.Options.UseBackColor = true;
            this.pnlHeader.Appearance.Options.UseBorderColor = true;
            this.pnlHeader.Appearance.Options.UseForeColor = true;
            this.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlHeader.ContentImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.ContentImage")));
            this.pnlHeader.Controls.Add(this.pnlBtnDate);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(873, 103);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBtnDate
            // 
            this.pnlBtnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtnDate.AutoSize = true;
            this.pnlBtnDate.BackColor = System.Drawing.Color.White;
            this.pnlBtnDate.Location = new System.Drawing.Point(102, 56);
            this.pnlBtnDate.Name = "pnlBtnDate";
            this.pnlBtnDate.Size = new System.Drawing.Size(669, 41);
            this.pnlBtnDate.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLeft.ContentImage = ((System.Drawing.Image)(resources.GetObject("pnlLeft.ContentImage")));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 103);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(102, 311);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.ContentImage = ((System.Drawing.Image)(resources.GetObject("pnlRight.ContentImage")));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(771, 103);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(102, 311);
            this.pnlRight.TabIndex = 2;
            // 
            // filmsBindingSource
            // 
            //this.filmsBindingSource.DataSource = typeof(TOS_WF.Models.Films);
            // 
            // Theater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Theater";
            this.Text = "Form1";

            this.ClientSize = new System.Drawing.Size(873, 414);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.IsMdiContainer = true;
            this.Name = "Theater";
            this.Text = "Theater";
            this.Load += new System.EventHandler(this.Theater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlHeader;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        public System.Windows.Forms.FlowLayoutPanel pnlBtnDate;
    }
}
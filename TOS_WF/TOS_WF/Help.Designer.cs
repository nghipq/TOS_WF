namespace TOS_WF
{
    partial class Help
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
            this.gdHelp = new DevExpress.XtraGrid.GridControl();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colA_Id = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colA_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdHelp
            // 
            this.gdHelp.DataSource = this.areaBindingSource;
            this.gdHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdHelp.Location = new System.Drawing.Point(0, 0);
            this.gdHelp.MainView = this.tileView1;
            this.gdHelp.Name = "gdHelp";
            this.gdHelp.Size = new System.Drawing.Size(965, 663);
            this.gdHelp.TabIndex = 0;
            this.gdHelp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataSource = typeof(TOS_WF.Models.Area);
            // 
            // tileView1
            // 
            this.tileView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colA_Id,
            this.colA_Name,
            this.colStatus});
            this.tileView1.GridControl = this.gdHelp;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(850, 800);
            // 
            // colA_Id
            // 
            this.colA_Id.FieldName = "A_Id";
            this.colA_Id.MinWidth = 25;
            this.colA_Id.Name = "colA_Id";
            this.colA_Id.Visible = true;
            this.colA_Id.VisibleIndex = 0;
            this.colA_Id.Width = 94;
            // 
            // colA_Name
            // 
            this.colA_Name.FieldName = "A_Name";
            this.colA_Name.MinWidth = 25;
            this.colA_Name.Name = "colA_Name";
            this.colA_Name.Visible = true;
            this.colA_Name.VisibleIndex = 1;
            this.colA_Name.Width = 94;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 25;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 94;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 663);
            this.Controls.Add(this.gdHelp);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "Help";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.gdHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdHelp;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colA_Id;
        private DevExpress.XtraGrid.Columns.TileViewColumn colA_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colStatus;
    }
}
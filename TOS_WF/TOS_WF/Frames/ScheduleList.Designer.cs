namespace TOS_WF.Frames
{
    partial class ScheduleList
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colStartTime = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.SchedulesList = new DevExpress.XtraGrid.GridControl();
            this.scheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleItem = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colid_Sche = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colid_Ses = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colid_F = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colid_C = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colid_R = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSche_Date = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colvipSeat = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colnormalPrice = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colvipPrice = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleItem)).BeginInit();
            this.SuspendLayout();
            // 
            // colStartTime
            // 
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.MinWidth = 23;
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 5;
            this.colStartTime.Width = 87;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(TOS_WF.Models.Schedule);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLeft.ContentImage = global::TOS_WF.Properties.Resources.bg_red;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(119, 470);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.ContentImage = global::TOS_WF.Properties.Resources.bg_red;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(677, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(119, 470);
            this.pnlRight.TabIndex = 1;
            // 
            // SchedulesList
            // 
            this.SchedulesList.DataSource = this.scheduleBindingSource1;
            this.SchedulesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchedulesList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SchedulesList.Location = new System.Drawing.Point(119, 0);
            this.SchedulesList.MainView = this.scheduleItem;
            this.SchedulesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SchedulesList.Name = "SchedulesList";
            this.SchedulesList.Size = new System.Drawing.Size(558, 470);
            this.SchedulesList.TabIndex = 2;
            this.SchedulesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.scheduleItem});
            // 
            // scheduleBindingSource1
            // 
            this.scheduleBindingSource1.DataSource = typeof(TOS_WF.Models.Schedule);
            // 
            // scheduleItem
            // 
            this.scheduleItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_Sche,
            this.colid_Ses,
            this.colid_F,
            this.colid_C,
            this.colid_R,
            this.colStartTime,
            this.colStatus,
            this.colSche_Date,
            this.colvipSeat,
            this.colnormalPrice,
            this.colvipPrice});
            this.scheduleItem.DetailHeight = 431;
            this.scheduleItem.GridControl = this.SchedulesList;
            this.scheduleItem.Name = "scheduleItem";
            this.scheduleItem.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.scheduleItem.OptionsTiles.IndentBetweenGroups = 0;
            this.scheduleItem.OptionsTiles.IndentBetweenItems = 0;
            this.scheduleItem.OptionsTiles.ItemSize = new System.Drawing.Size(536, 100);
            this.scheduleItem.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.scheduleItem.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.scheduleItem.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.scheduleItem.OptionsTiles.RowCount = 0;
            this.scheduleItem.TileColumns.Add(tableColumnDefinition1);
            this.scheduleItem.TileColumns.Add(tableColumnDefinition2);
            this.scheduleItem.TileColumns.Add(tableColumnDefinition3);
            this.scheduleItem.TileRows.Add(tableRowDefinition1);
            this.scheduleItem.TileRows.Add(tableRowDefinition2);
            this.scheduleItem.TileRows.Add(tableRowDefinition3);
            tileViewItemElement1.Column = this.colStartTime;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.RowIndex = 1;
            tileViewItemElement1.Text = "colStartTime";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.scheduleItem.TileTemplate.Add(tileViewItemElement1);
            // 
            // colid_Sche
            // 
            this.colid_Sche.FieldName = "id_Sche";
            this.colid_Sche.MinWidth = 23;
            this.colid_Sche.Name = "colid_Sche";
            this.colid_Sche.Visible = true;
            this.colid_Sche.VisibleIndex = 0;
            this.colid_Sche.Width = 87;
            // 
            // colid_Ses
            // 
            this.colid_Ses.FieldName = "id_Ses";
            this.colid_Ses.MinWidth = 23;
            this.colid_Ses.Name = "colid_Ses";
            this.colid_Ses.Visible = true;
            this.colid_Ses.VisibleIndex = 1;
            this.colid_Ses.Width = 87;
            // 
            // colid_F
            // 
            this.colid_F.FieldName = "id_F";
            this.colid_F.MinWidth = 23;
            this.colid_F.Name = "colid_F";
            this.colid_F.Visible = true;
            this.colid_F.VisibleIndex = 2;
            this.colid_F.Width = 87;
            // 
            // colid_C
            // 
            this.colid_C.FieldName = "id_C";
            this.colid_C.MinWidth = 23;
            this.colid_C.Name = "colid_C";
            this.colid_C.Visible = true;
            this.colid_C.VisibleIndex = 3;
            this.colid_C.Width = 87;
            // 
            // colid_R
            // 
            this.colid_R.FieldName = "id_R";
            this.colid_R.MinWidth = 23;
            this.colid_R.Name = "colid_R";
            this.colid_R.Visible = true;
            this.colid_R.VisibleIndex = 4;
            this.colid_R.Width = 87;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 23;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            this.colStatus.Width = 87;
            // 
            // colSche_Date
            // 
            this.colSche_Date.FieldName = "Sche_Date";
            this.colSche_Date.MinWidth = 23;
            this.colSche_Date.Name = "colSche_Date";
            this.colSche_Date.Visible = true;
            this.colSche_Date.VisibleIndex = 7;
            this.colSche_Date.Width = 87;
            // 
            // colvipSeat
            // 
            this.colvipSeat.FieldName = "vipSeat";
            this.colvipSeat.MinWidth = 23;
            this.colvipSeat.Name = "colvipSeat";
            this.colvipSeat.Visible = true;
            this.colvipSeat.VisibleIndex = 8;
            this.colvipSeat.Width = 87;
            // 
            // colnormalPrice
            // 
            this.colnormalPrice.FieldName = "normalPrice";
            this.colnormalPrice.MinWidth = 23;
            this.colnormalPrice.Name = "colnormalPrice";
            this.colnormalPrice.Visible = true;
            this.colnormalPrice.VisibleIndex = 9;
            this.colnormalPrice.Width = 87;
            // 
            // colvipPrice
            // 
            this.colvipPrice.FieldName = "vipPrice";
            this.colvipPrice.MinWidth = 23;
            this.colvipPrice.Name = "colvipPrice";
            this.colvipPrice.Visible = true;
            this.colvipPrice.VisibleIndex = 10;
            this.colvipPrice.Width = 87;
            // 
            // ScheduleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 470);
            this.Controls.Add(this.SchedulesList);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScheduleList";
            this.Text = "ScheduleList";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private System.Windows.Forms.BindingSource scheduleBindingSource1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colid_Sche;
        private DevExpress.XtraGrid.Columns.TileViewColumn colid_Ses;
        private DevExpress.XtraGrid.Columns.TileViewColumn colid_F;
        private DevExpress.XtraGrid.Columns.TileViewColumn colid_C;
        private DevExpress.XtraGrid.Columns.TileViewColumn colid_R;
        private DevExpress.XtraGrid.Columns.TileViewColumn colStartTime;
        private DevExpress.XtraGrid.Columns.TileViewColumn colStatus;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSche_Date;
        private DevExpress.XtraGrid.Columns.TileViewColumn colvipSeat;
        private DevExpress.XtraGrid.Columns.TileViewColumn colnormalPrice;
        private DevExpress.XtraGrid.Columns.TileViewColumn colvipPrice;
        public DevExpress.XtraGrid.GridControl SchedulesList;
        public DevExpress.XtraGrid.Views.Tile.TileView scheduleItem;
    }
}
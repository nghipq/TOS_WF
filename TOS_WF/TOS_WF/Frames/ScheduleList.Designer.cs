namespace TOS_WF.Frames
{
    partial class ScheduleList
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colStartTime = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.SchedulesList = new DevExpress.XtraGrid.GridControl();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ScheduleItem = new DevExpress.XtraGrid.Views.Tile.TileView();
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
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleItem)).BeginInit();
            this.SuspendLayout();
            // 
            // colStartTime
            // 
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 5;
            // 
            // SchedulesList
            // 
            this.SchedulesList.DataSource = this.scheduleBindingSource;
            this.SchedulesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchedulesList.Location = new System.Drawing.Point(0, 0);
            this.SchedulesList.MainView = this.ScheduleItem;
            this.SchedulesList.Name = "SchedulesList";
            this.SchedulesList.Size = new System.Drawing.Size(682, 382);
            this.SchedulesList.TabIndex = 0;
            this.SchedulesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ScheduleItem});
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(TOS_WF.Models.Schedule);
            // 
            // ScheduleItem
            // 
            this.ScheduleItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.ScheduleItem.GridControl = this.SchedulesList;
            this.ScheduleItem.Name = "ScheduleItem";
            this.ScheduleItem.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.ScheduleItem.OptionsTiles.IndentBetweenGroups = 0;
            this.ScheduleItem.OptionsTiles.IndentBetweenItems = 0;
            this.ScheduleItem.OptionsTiles.ItemSize = new System.Drawing.Size(530, 76);
            this.ScheduleItem.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.ScheduleItem.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ScheduleItem.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.ScheduleItem.OptionsTiles.RowCount = 0;
            this.ScheduleItem.TileColumns.Add(tableColumnDefinition1);
            this.ScheduleItem.TileColumns.Add(tableColumnDefinition2);
            this.ScheduleItem.TileColumns.Add(tableColumnDefinition3);
            this.ScheduleItem.TileRows.Add(tableRowDefinition1);
            tileViewItemElement1.Column = this.colStartTime;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colStartTime";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.ScheduleItem.TileTemplate.Add(tileViewItemElement1);
            // 
            // colid_Sche
            // 
            this.colid_Sche.FieldName = "id_Sche";
            this.colid_Sche.Name = "colid_Sche";
            this.colid_Sche.Visible = true;
            this.colid_Sche.VisibleIndex = 0;
            // 
            // colid_Ses
            // 
            this.colid_Ses.FieldName = "id_Ses";
            this.colid_Ses.Name = "colid_Ses";
            this.colid_Ses.Visible = true;
            this.colid_Ses.VisibleIndex = 1;
            // 
            // colid_F
            // 
            this.colid_F.FieldName = "id_F";
            this.colid_F.Name = "colid_F";
            this.colid_F.Visible = true;
            this.colid_F.VisibleIndex = 2;
            // 
            // colid_C
            // 
            this.colid_C.FieldName = "id_C";
            this.colid_C.Name = "colid_C";
            this.colid_C.Visible = true;
            this.colid_C.VisibleIndex = 3;
            // 
            // colid_R
            // 
            this.colid_R.FieldName = "id_R";
            this.colid_R.Name = "colid_R";
            this.colid_R.Visible = true;
            this.colid_R.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            // 
            // colSche_Date
            // 
            this.colSche_Date.FieldName = "Sche_Date";
            this.colSche_Date.Name = "colSche_Date";
            this.colSche_Date.Visible = true;
            this.colSche_Date.VisibleIndex = 7;
            // 
            // colvipSeat
            // 
            this.colvipSeat.FieldName = "vipSeat";
            this.colvipSeat.Name = "colvipSeat";
            this.colvipSeat.Visible = true;
            this.colvipSeat.VisibleIndex = 8;
            // 
            // colnormalPrice
            // 
            this.colnormalPrice.FieldName = "normalPrice";
            this.colnormalPrice.Name = "colnormalPrice";
            this.colnormalPrice.Visible = true;
            this.colnormalPrice.VisibleIndex = 9;
            // 
            // colvipPrice
            // 
            this.colvipPrice.FieldName = "vipPrice";
            this.colvipPrice.Name = "colvipPrice";
            this.colvipPrice.Visible = true;
            this.colvipPrice.VisibleIndex = 10;
            // 
            // ScheduleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 382);
            this.Controls.Add(this.SchedulesList);
            this.Name = "ScheduleList";
            this.Text = "ScheduleList";
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Tile.TileView ScheduleItem;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
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
    }
}
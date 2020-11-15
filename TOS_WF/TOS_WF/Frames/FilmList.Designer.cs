namespace TOS_WF.Frames
{
    partial class FilmList
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
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan4 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement8 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colPicture = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colF_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colF_Time = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colRating = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.FilmsList = new DevExpress.XtraGrid.GridControl();
            this.filmItem = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colid_F = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colid_P = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colP_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colReleaseDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colLimitAge = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAirDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPoster = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colF_Trailer = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmItem)).BeginInit();
            this.SuspendLayout();
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.OptionsColumn.ReadOnly = true;
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 12;
            // 
            // colF_Name
            // 
            this.colF_Name.FieldName = "F_Name";
            this.colF_Name.Name = "colF_Name";
            this.colF_Name.Visible = true;
            this.colF_Name.VisibleIndex = 1;
            // 
            // colF_Time
            // 
            this.colF_Time.FieldName = "F_Time";
            this.colF_Time.Name = "colF_Time";
            this.colF_Time.Visible = true;
            this.colF_Time.VisibleIndex = 13;
            // 
            // colRating
            // 
            this.colRating.FieldName = "Rating";
            this.colRating.Name = "colRating";
            this.colRating.Visible = true;
            this.colRating.VisibleIndex = 5;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 9;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataSource = typeof(TOS_WF.Models.Films);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLeft.ContentImage = global::TOS_WF.Properties.Resources.Background;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(102, 429);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.ContentImage = global::TOS_WF.Properties.Resources.Background1;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(753, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(102, 429);
            this.pnlRight.TabIndex = 1;
            // 
            // FilmsList
            // 
            this.FilmsList.DataSource = this.filmsBindingSource;
            this.FilmsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmsList.Location = new System.Drawing.Point(102, 0);
            this.FilmsList.MainView = this.filmItem;
            this.FilmsList.Name = "FilmsList";
            this.FilmsList.Size = new System.Drawing.Size(651, 429);
            this.FilmsList.TabIndex = 2;
            this.FilmsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.filmItem});
            // 
            // filmItem
            // 
            this.filmItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_F,
            this.colF_Name,
            this.colid_P,
            this.colP_Name,
            this.colReleaseDate,
            this.colRating,
            this.colLimitAge,
            this.colAirDate,
            this.colEndDate,
            this.colDescription,
            this.colStatus,
            this.colPoster,
            this.colPicture,
            this.colF_Time,
            this.colF_Trailer});
            this.filmItem.GridControl = this.FilmsList;
            this.filmItem.Name = "filmItem";
            this.filmItem.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.filmItem.OptionsTiles.IndentBetweenGroups = 0;
            this.filmItem.OptionsTiles.IndentBetweenItems = 0;
            this.filmItem.OptionsTiles.ItemSize = new System.Drawing.Size(798, 158);
            this.filmItem.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.filmItem.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.filmItem.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.filmItem.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 140D;
            tableColumnDefinition2.Length.Value = 89D;
            tableColumnDefinition3.Length.Value = 545D;
            this.filmItem.TileColumns.Add(tableColumnDefinition1);
            this.filmItem.TileColumns.Add(tableColumnDefinition2);
            this.filmItem.TileColumns.Add(tableColumnDefinition3);
            tableRowDefinition1.Length.Value = 31D;
            tableRowDefinition2.Length.Value = 22D;
            tableRowDefinition3.Length.Value = 17D;
            tableRowDefinition4.Length.Value = 20D;
            tableRowDefinition5.Length.Value = 16D;
            this.filmItem.TileRows.Add(tableRowDefinition1);
            this.filmItem.TileRows.Add(tableRowDefinition2);
            this.filmItem.TileRows.Add(tableRowDefinition3);
            this.filmItem.TileRows.Add(tableRowDefinition4);
            this.filmItem.TileRows.Add(tableRowDefinition5);
            tableSpan1.RowSpan = 5;
            tableSpan2.ColumnIndex = 1;
            tableSpan2.ColumnSpan = 2;
            tableSpan3.ColumnIndex = 1;
            tableSpan3.RowIndex = 3;
            tableSpan3.RowSpan = 2;
            tableSpan4.ColumnIndex = 2;
            tableSpan4.RowIndex = 3;
            tableSpan4.RowSpan = 2;
            this.filmItem.TileSpans.Add(tableSpan1);
            this.filmItem.TileSpans.Add(tableSpan2);
            this.filmItem.TileSpans.Add(tableSpan3);
            this.filmItem.TileSpans.Add(tableSpan4);
            tileViewItemElement1.Column = this.colPicture;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.RowIndex = 2;
            tileViewItemElement1.Text = "colPicture";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement2.Column = this.colF_Name;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.Text = "colF_Name";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement2.TextLocation = new System.Drawing.Point(10, 0);
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "Thời Lượng";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement3.TextLocation = new System.Drawing.Point(10, 0);
            tileViewItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 2;
            tileViewItemElement4.Text = "Đánh Giá";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement4.TextLocation = new System.Drawing.Point(10, 0);
            tileViewItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement5.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement5.ColumnIndex = 1;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.RowIndex = 3;
            tileViewItemElement5.Text = "Nội Dung";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement5.TextLocation = new System.Drawing.Point(10, 10);
            tileViewItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement6.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement6.Column = this.colF_Time;
            tileViewItemElement6.ColumnIndex = 2;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.RowIndex = 1;
            tileViewItemElement6.Text = "colF_Time";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement6.TextLocation = new System.Drawing.Point(10, 0);
            tileViewItemElement7.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement7.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement7.Column = this.colRating;
            tileViewItemElement7.ColumnIndex = 2;
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement7.RowIndex = 2;
            tileViewItemElement7.Text = "colRating";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement7.TextLocation = new System.Drawing.Point(10, 0);
            tileViewItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement8.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement8.Column = this.colDescription;
            tileViewItemElement8.ColumnIndex = 2;
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement8.RowIndex = 3;
            tileViewItemElement8.Text = "colDescription";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement8.TextLocation = new System.Drawing.Point(10, 10);
            this.filmItem.TileTemplate.Add(tileViewItemElement1);
            this.filmItem.TileTemplate.Add(tileViewItemElement2);
            this.filmItem.TileTemplate.Add(tileViewItemElement3);
            this.filmItem.TileTemplate.Add(tileViewItemElement4);
            this.filmItem.TileTemplate.Add(tileViewItemElement5);
            this.filmItem.TileTemplate.Add(tileViewItemElement6);
            this.filmItem.TileTemplate.Add(tileViewItemElement7);
            this.filmItem.TileTemplate.Add(tileViewItemElement8);
            // 
            // colid_F
            // 
            this.colid_F.FieldName = "id_F";
            this.colid_F.Name = "colid_F";
            this.colid_F.Visible = true;
            this.colid_F.VisibleIndex = 0;
            // 
            // colid_P
            // 
            this.colid_P.FieldName = "id_P";
            this.colid_P.Name = "colid_P";
            this.colid_P.Visible = true;
            this.colid_P.VisibleIndex = 2;
            // 
            // colP_Name
            // 
            this.colP_Name.FieldName = "P_Name";
            this.colP_Name.Name = "colP_Name";
            this.colP_Name.Visible = true;
            this.colP_Name.VisibleIndex = 3;
            // 
            // colReleaseDate
            // 
            this.colReleaseDate.FieldName = "ReleaseDate";
            this.colReleaseDate.Name = "colReleaseDate";
            this.colReleaseDate.Visible = true;
            this.colReleaseDate.VisibleIndex = 4;
            // 
            // colLimitAge
            // 
            this.colLimitAge.FieldName = "LimitAge";
            this.colLimitAge.Name = "colLimitAge";
            this.colLimitAge.Visible = true;
            this.colLimitAge.VisibleIndex = 6;
            // 
            // colAirDate
            // 
            this.colAirDate.FieldName = "AirDate";
            this.colAirDate.Name = "colAirDate";
            this.colAirDate.Visible = true;
            this.colAirDate.VisibleIndex = 7;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 8;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 10;
            // 
            // colPoster
            // 
            this.colPoster.FieldName = "Poster";
            this.colPoster.Name = "colPoster";
            this.colPoster.Visible = true;
            this.colPoster.VisibleIndex = 11;
            // 
            // colF_Trailer
            // 
            this.colF_Trailer.FieldName = "F_Trailer";
            this.colF_Trailer.Name = "colF_Trailer";
            this.colF_Trailer.Visible = true;
            this.colF_Trailer.VisibleIndex = 14;
            // 
            // FilmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 429);
            this.Controls.Add(this.FilmsList);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FilmList";
            this.Text = "FilmList";
            this.Load += new System.EventHandler(this.FilmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.BindingSource filmsBindingSource;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        public DevExpress.XtraGrid.GridControl FilmsList;
        private DevExpress.XtraGrid.Columns.TileViewColumn colid_F;
        private DevExpress.XtraGrid.Columns.TileViewColumn colF_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colid_P;
        private DevExpress.XtraGrid.Columns.TileViewColumn colP_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colReleaseDate;
        private DevExpress.XtraGrid.Columns.TileViewColumn colRating;
        private DevExpress.XtraGrid.Columns.TileViewColumn colLimitAge;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAirDate;
        private DevExpress.XtraGrid.Columns.TileViewColumn colEndDate;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn colStatus;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPoster;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPicture;
        private DevExpress.XtraGrid.Columns.TileViewColumn colF_Time;
        private DevExpress.XtraGrid.Columns.TileViewColumn colF_Trailer;
        public DevExpress.XtraGrid.Views.Tile.TileView filmItem;
    }
}
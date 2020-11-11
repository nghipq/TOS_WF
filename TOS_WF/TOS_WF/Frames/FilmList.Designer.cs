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
            this.colRating = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colF_Time = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.FilmsList = new DevExpress.XtraGrid.GridControl();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilmItem = new DevExpress.XtraGrid.Views.Tile.TileView();
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
            ((System.ComponentModel.ISupportInitialize)(this.FilmsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmItem)).BeginInit();
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
            // colRating
            // 
            this.colRating.FieldName = "Rating";
            this.colRating.Name = "colRating";
            this.colRating.Visible = true;
            this.colRating.VisibleIndex = 5;
            // 
            // colF_Time
            // 
            this.colF_Time.FieldName = "F_Time";
            this.colF_Time.Name = "colF_Time";
            this.colF_Time.Visible = true;
            this.colF_Time.VisibleIndex = 13;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 9;
            // 
            // FilmsList
            // 
            this.FilmsList.DataSource = this.filmsBindingSource;
            this.FilmsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmsList.Location = new System.Drawing.Point(0, 0);
            this.FilmsList.MainView = this.FilmItem;
            this.FilmsList.Name = "FilmsList";
            this.FilmsList.Size = new System.Drawing.Size(778, 429);
            this.FilmsList.TabIndex = 0;
            this.FilmsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.FilmItem});
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataSource = typeof(TOS_WF.Models.Films);
            // 
            // FilmItem
            // 
            this.FilmItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.FilmItem.GridControl = this.FilmsList;
            this.FilmItem.Name = "FilmItem";
            this.FilmItem.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.FilmItem.OptionsTiles.IndentBetweenGroups = 0;
            this.FilmItem.OptionsTiles.IndentBetweenItems = 0;
            this.FilmItem.OptionsTiles.ItemSize = new System.Drawing.Size(556, 160);
            this.FilmItem.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.FilmItem.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.FilmItem.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.FilmItem.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 104D;
            tableColumnDefinition2.Length.Value = 94D;
            tableColumnDefinition3.Length.Value = 334D;
            this.FilmItem.TileColumns.Add(tableColumnDefinition1);
            this.FilmItem.TileColumns.Add(tableColumnDefinition2);
            this.FilmItem.TileColumns.Add(tableColumnDefinition3);
            tableRowDefinition1.Length.Value = 45D;
            tableRowDefinition2.Length.Value = 26D;
            tableRowDefinition3.Length.Value = 25D;
            tableRowDefinition4.Length.Value = 27D;
            tableRowDefinition5.Length.Value = 21D;
            this.FilmItem.TileRows.Add(tableRowDefinition1);
            this.FilmItem.TileRows.Add(tableRowDefinition2);
            this.FilmItem.TileRows.Add(tableRowDefinition3);
            this.FilmItem.TileRows.Add(tableRowDefinition4);
            this.FilmItem.TileRows.Add(tableRowDefinition5);
            tableSpan1.RowSpan = 5;
            tableSpan2.ColumnIndex = 1;
            tableSpan2.ColumnSpan = 2;
            tableSpan3.ColumnIndex = 1;
            tableSpan3.RowIndex = 3;
            tableSpan3.RowSpan = 2;
            tableSpan4.ColumnIndex = 2;
            tableSpan4.RowIndex = 3;
            tableSpan4.RowSpan = 2;
            this.FilmItem.TileSpans.Add(tableSpan1);
            this.FilmItem.TileSpans.Add(tableSpan2);
            this.FilmItem.TileSpans.Add(tableSpan3);
            this.FilmItem.TileSpans.Add(tableSpan4);
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
            tileViewItemElement3.Text = "Thời Lượng:";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement3.TextLocation = new System.Drawing.Point(10, 0);
            tileViewItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 2;
            tileViewItemElement4.Text = "Đánh Giá:";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement4.TextLocation = new System.Drawing.Point(10, 0);
            tileViewItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement5.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement5.ColumnIndex = 1;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.RowIndex = 3;
            tileViewItemElement5.Text = "Nội Dung:";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement5.TextLocation = new System.Drawing.Point(10, 10);
            tileViewItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement6.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement6.Column = this.colRating;
            tileViewItemElement6.ColumnIndex = 2;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.RowIndex = 2;
            tileViewItemElement6.Text = "colRating";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement7.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement7.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement7.Column = this.colF_Time;
            tileViewItemElement7.ColumnIndex = 2;
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement7.RowIndex = 1;
            tileViewItemElement7.Text = "colF_Time";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement8.Column = this.colDescription;
            tileViewItemElement8.ColumnIndex = 2;
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement8.RowIndex = 3;
            tileViewItemElement8.Text = "colDescription";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement8.TextLocation = new System.Drawing.Point(0, 10);
            this.FilmItem.TileTemplate.Add(tileViewItemElement1);
            this.FilmItem.TileTemplate.Add(tileViewItemElement2);
            this.FilmItem.TileTemplate.Add(tileViewItemElement3);
            this.FilmItem.TileTemplate.Add(tileViewItemElement4);
            this.FilmItem.TileTemplate.Add(tileViewItemElement5);
            this.FilmItem.TileTemplate.Add(tileViewItemElement6);
            this.FilmItem.TileTemplate.Add(tileViewItemElement7);
            this.FilmItem.TileTemplate.Add(tileViewItemElement8);
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
            this.ClientSize = new System.Drawing.Size(778, 429);
            this.Controls.Add(this.FilmsList);
            this.Name = "FilmList";
            this.Text = "FilmList";
            this.Load += new System.EventHandler(this.FilmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilmsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl FilmsList;
        public System.Windows.Forms.BindingSource filmsBindingSource;
        public DevExpress.XtraGrid.Views.Tile.TileView FilmItem;
        public DevExpress.XtraGrid.Columns.TileViewColumn colid_F;
        public DevExpress.XtraGrid.Columns.TileViewColumn colF_Name;
        public DevExpress.XtraGrid.Columns.TileViewColumn colid_P;
        public DevExpress.XtraGrid.Columns.TileViewColumn colP_Name;
        public DevExpress.XtraGrid.Columns.TileViewColumn colReleaseDate;
        public DevExpress.XtraGrid.Columns.TileViewColumn colRating;
        public DevExpress.XtraGrid.Columns.TileViewColumn colLimitAge;
        public DevExpress.XtraGrid.Columns.TileViewColumn colAirDate;
        public DevExpress.XtraGrid.Columns.TileViewColumn colEndDate;
        public DevExpress.XtraGrid.Columns.TileViewColumn colDescription;
        public DevExpress.XtraGrid.Columns.TileViewColumn colStatus;
        public DevExpress.XtraGrid.Columns.TileViewColumn colPoster;
        public DevExpress.XtraGrid.Columns.TileViewColumn colPicture;
        public DevExpress.XtraGrid.Columns.TileViewColumn colF_Time;
        public DevExpress.XtraGrid.Columns.TileViewColumn colF_Trailer;
        private System.ComponentModel.IContainer components;
    }
}
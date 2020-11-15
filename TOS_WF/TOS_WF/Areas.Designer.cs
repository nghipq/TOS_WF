namespace TOS_WF
{
    partial class Areas
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
            this.cinemaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cbCinema = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cinemaBindingSource1
            // 
            this.cinemaBindingSource1.DataSource = typeof(TOS_WF.Models.Cinema);
            // 
            // cinemaBindingSource
            // 
            this.cinemaBindingSource.DataSource = typeof(TOS_WF.Models.Cinema);
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataSource = typeof(TOS_WF.Models.Area);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.lblChoose);
            this.panel2.Controls.Add(this.lblCinema);
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Controls.Add(this.cbCinema);
            this.panel2.Controls.Add(this.cbArea);
            this.panel2.Location = new System.Drawing.Point(418, 151);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 364);
            this.panel2.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSubmit.Location = new System.Drawing.Point(149, 271);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(286, 59);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.Transparent;
            this.lblChoose.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblChoose.Location = new System.Drawing.Point(118, 17);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(342, 60);
            this.lblChoose.TabIndex = 4;
            this.lblChoose.Text = "Choose Cinema";
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.BackColor = System.Drawing.Color.Transparent;
            this.lblCinema.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCinema.Location = new System.Drawing.Point(22, 177);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(118, 41);
            this.lblCinema.TabIndex = 3;
            this.lblCinema.Text = "Cinema";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblArea.Location = new System.Drawing.Point(22, 114);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(78, 41);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            // 
            // cbCinema
            // 
            this.cbCinema.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cinemaBindingSource1, "Id_C", true));
            this.cbCinema.DataSource = this.cinemaBindingSource;
            this.cbCinema.DisplayMember = "C_Name";
            this.cbCinema.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCinema.FormattingEnabled = true;
            this.cbCinema.Location = new System.Drawing.Point(149, 186);
            this.cbCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCinema.Name = "cbCinema";
            this.cbCinema.Size = new System.Drawing.Size(375, 40);
            this.cbCinema.TabIndex = 1;
            this.cbCinema.ValueMember = "Id_C";
            this.cbCinema.SelectedIndexChanged += new System.EventHandler(this.cbCinema_SelectedIndexChanged);
            // 
            // cbArea
            // 
            this.cbArea.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.areaBindingSource, "A_Id", true));
            this.cbArea.DataSource = this.areaBindingSource;
            this.cbArea.DisplayMember = "A_Name";
            this.cbArea.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(149, 114);
            this.cbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(375, 40);
            this.cbArea.TabIndex = 0;
            this.cbArea.ValueMember = "A_Id";
            // 
            // Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::TOS_WF.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1256, 620);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Areas";
            this.Text = "Area";
            this.Load += new System.EventHandler(this.Areas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource areaBindingSource;
        private System.Windows.Forms.BindingSource cinemaBindingSource1;
        private System.Windows.Forms.BindingSource cinemaBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.Label lblArea;
        public System.Windows.Forms.ComboBox cbCinema;
        public System.Windows.Forms.ComboBox cbArea;
        public System.Windows.Forms.Button btnSubmit;
    }
}
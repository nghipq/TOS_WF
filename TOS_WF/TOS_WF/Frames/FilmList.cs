using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TOS_WF.Models;

namespace TOS_WF.Frames
{
    public partial class FilmList : DevExpress.XtraEditors.XtraForm
    {
        public FilmList()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FilmList_Load(object sender, EventArgs e)
        {

        }
    }
}
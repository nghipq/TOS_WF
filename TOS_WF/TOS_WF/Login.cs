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
using TOS_WF.DAO;

namespace TOS_WF
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public string username { get; set; }
        public string password { get; set; }
        public Login()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            pnlLogin.BackColor = Color.FromArgb(25, Color.Black);
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtPassword.PasswordChar = '*';
        }
    }
}
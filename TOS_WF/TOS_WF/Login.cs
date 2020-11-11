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
        public Login()
        {
            InitializeComponent();
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            LoginDAO ldao = new LoginDAO();
            //Theater theater = new Theater(1);
            bool isLogin = ldao.Login(txtUsername.Text, txtPassword.Text);
            if (isLogin)
            {
                this.Visible = false;
                //theater.Visible = true;
            }
        }
    }
}
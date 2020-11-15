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
using TOS_WF.Models;

namespace TOS_WF
{
    public partial class Help : DevExpress.XtraEditors.XtraForm
    {
        public Help()
        {
            InitializeComponent();
          
            this.gdHelp.DataSource = new HelpList();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
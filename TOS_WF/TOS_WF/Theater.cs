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
using TOS_WF.DAO;
using DevExpress.Utils.Extensions;
using TOS_WF.Frames;

namespace TOS_WF
{
    public partial class Theater : DevExpress.XtraEditors.XtraForm
    {
        List<DateSchedule> dates = new List<DateSchedule>();
        public FilmList pnlFilm;


        public Theater()
        {
            dates = new DateScheduleDAO().getDateScheduleByCinema(1);

            InitializeComponent();

            pnlFilm = new FilmList();
            pnlFilm.MdiParent = this;
            pnlFilm.Show();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        public void Load_Dates()
        {
            Button[] btn = new Button[dates.Count];
            Point[] p = new Point[dates.Count];
            int i = 0;

            dates.ForEach(date =>
            {

                btn[i] = new Button();
                btn[i].Height = 30;
                btn[i].Width = 80;
                btn[i].Text = dates[i].dateSchedule.DayOfWeek.ToString();
                //btn[i].Text = "i";
                btn[i].Name = "btn_day_" + i;

                p[i] = new Point();
                p[i].X = i * 90;
                p[i].Y = 0;

                btn[i].PointToClient(p[i]);//tinh toan toa do voi cac may khac nhau
                btn[i].Show();
                btn[i].Click += new EventHandler(this.btnday_Click);
                i++;
            //}
            });
            pnlBtnDate.Controls.AddRange(btn);



        }

        public void btnday_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string index = btn.Name.Substring(8);

            Load_Films(Convert.ToInt32(index));
        }

        public void Load_Films(int dayIndex)
        {
            
            pnlFilm.FilmsList.DataSource = dates[dayIndex].films;
            
        }

        private void Theater_Load(object sender, EventArgs e)
        {
            Load_Dates();
            Load_Films(0);
        }
    }
}
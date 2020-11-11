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
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Columns;

namespace TOS_WF
{
    public partial class Theater : DevExpress.XtraEditors.XtraForm
    {
        List<DateSchedule> dates = new List<DateSchedule>();
        public FilmList pnlFilm;
        public ScheduleList pnlSchedule;
        public int dayIndex;
        public Booking booking;

        public Theater(int id_C)
        {
            dates = new DateScheduleDAO().getDateScheduleByCinema(id_C);

            InitializeComponent();

            pnlFilm = new FilmList();
            pnlFilm.filmItem.Click += new EventHandler(this.Schedule_Load);
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
            dayIndex = Convert.ToInt32(btn.Name.Substring(8));

            Load_Films(dayIndex);
        }

        public void Load_Films(int dayIndex)
        {
            pnlFilm.FilmsList.DataSource = dates[dayIndex].films;
        }

        public void Load_Schedules(int dayIndex, int filmsIndex)
        {
            pnlSchedule = new ScheduleList();
            pnlSchedule.MdiParent = this;
            pnlSchedule.SchedulesList.DataSource = dates[dayIndex].films[filmsIndex].Schedules;
            pnlSchedule.scheduleItem.Click += new EventHandler(this.Load_Booking);
            pnlSchedule.Show();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            TileView tileView = sender as TileView;
            int fId = Convert.ToInt32(tileView.GetRowCellValue(tileView.FocusedRowHandle, "id_F").ToString());
            int filmsIndex = dates[dayIndex].films.FindIndex(item => item.id_F == fId);

            Load_Schedules(dayIndex, filmsIndex);
        }

        private void Load_Booking(object sender, EventArgs e)
        {
            TileView tileView = sender as TileView;
            int Sche_id = Convert.ToInt32(tileView.GetRowCellValue(tileView.FocusedRowHandle, "id_Sche").ToString());

            //Console.WriteLine(Sche_id);
            this.Visible = false;
            booking = new Booking(Sche_id);
            booking.Show();
        }

        private void Theater_Load(object sender, EventArgs e)
        {
            Load_Dates();
            Load_Films(0);
        }
    }
}
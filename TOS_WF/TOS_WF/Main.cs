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
using TOS_WF.Frames;
using DevExpress.XtraGrid.Views.Tile;

namespace TOS_WF
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        List<DateSchedule> dates = new List<DateSchedule>();
        public int id_C { get; set; }
        public int id_Cus { get; set; }
        public int id_Staff { get; set; }
        public int dayIndex { get; set; }
        public int filmsIndex { get; set; }
        public int sche_Id{ get; set; }
        public int room_Id { get; set; }
        public string Choose_Seat { get; set; }
        public string Choose_SeatId { get; set; }
        public int billTotalPrice { get; set; }
        public FilmList frmFilms { get; set; }
        public ScheduleList frmSchedule { get; set; }
        public frmRoom frmRoom { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        public void Load_Cinema(int id_C)
        {
            dates = new DateScheduleDAO().getDateScheduleByCinema(id_C);
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
            frmFilms.FilmsList.DataSource = dates[dayIndex].films;
        }

        public void Load_Schedules(int dayIndex, int filmsIndex)
        {
            
            frmSchedule.SchedulesList.DataSource = dates[dayIndex].films[filmsIndex].Schedules;
            frmSchedule.scheduleItem.Click += new EventHandler(this.Load_Booking); 
        }

        public void Load_FilmsScreen()
        {
            frmFilms = new FilmList();
            frmFilms.MdiParent = this;
            frmFilms.filmItem.Click += new EventHandler(this.Schedule_Load);
            frmFilms.Show();
        }

        public void Load_ScheduleScreen()
        {
            frmFilms.Visible = false;
            frmSchedule = new ScheduleList();
            frmSchedule.MdiParent = this;
            frmSchedule.Show();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            TileView tileView = sender as TileView;
            int fId = Convert.ToInt32(tileView.GetRowCellValue(tileView.FocusedRowHandle, "id_F").ToString());
            int filmsIndex = dates[dayIndex].films.FindIndex(item => item.id_F == fId);

            Load_ScheduleScreen();
            Load_Schedules(dayIndex, filmsIndex);
        }

        private void Load_Booking(object sender, EventArgs e)
        {
            TileView tileView = sender as TileView;
            sche_Id = Convert.ToInt32(tileView.GetRowCellValue(tileView.FocusedRowHandle, "id_Sche").ToString());

            frmSchedule.Visible = false;
            frmRoom = new frmRoom(sche_Id);
            frmRoom.MdiParent = this;
            frmRoom.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Load_Cinema(1);       
            Load_Dates();
            Load_FilmsScreen();
            Load_Films(0);
            
        }
    }
}
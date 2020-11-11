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
        public static List<string> strl = new List<string>();
        public static List<string> ticketID = new List<string>();
        public int Sche_id { get; set; }
        public int id_C { get; set; }
        public string C_Name { get; set; }
        public int id_Cus { get; set; }
        public int id_Staff { get; set; }
        public int dayIndex { get; set; }
        public int filmsIndex { get; set; }
        public int sche_Id { get; set; }
        public string sche_Name { get; set; }
        public int room_Id { get; set; }
        public string Room_Name { get; set; }
        public int billTotalPrice { get; set; }
        public FilmList frmFilms { get; set; }
        public ScheduleList frmSchedule { get; set; }
        public frmRoom frmRoom { get; set; }
        public ConfirmTicket frmConfirmTicket { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        /*Load dữ liệu*/

        /**
         * Load các ngày có lịch chiếu của 1 rạp
         */
        public void Load_Cinema(int id_C)
        {
            dates = new DateScheduleDAO().getDateScheduleByCinema(id_C);
        }

        /**
         * Load các phim có lịch chiếu của 1 ngày
         */
        public void Load_Films(int dayIndex)
        {
            frmFilms.FilmsList.DataSource = dates[dayIndex].films;
        }

        /**
         * Load các lịch chiếu của 1 phim
         */
        public void Load_Schedules(int dayIndex, int filmsIndex)
        {

            frmSchedule.SchedulesList.DataSource = dates[dayIndex].films[filmsIndex].Schedules;
            frmSchedule.scheduleItem.Click += new EventHandler(this.Load_Booking);
        }

        /*Tạo giao diện*/

        /**
         * Tạo nút chọn ngày
         */
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

        /**
         * Load màng hình chọn phim
         */
        public void Load_FilmsScreen()
        {
            frmFilms = new FilmList();
            frmFilms.MdiParent = this;
            frmFilms.filmItem.Click += new EventHandler(this.Schedule_Load);
            frmFilms.Show();
        }
        public void LoadRoom(int sche_Id, string Room_Name)
        {
            frmSchedule.Visible = false;
            frmRoom = new frmRoom(sche_Id, Room_Name);
            frmRoom.MdiParent = this;
            frmRoom.pbNext.Click+= new EventHandler(this.btnNext_Click);
            frmRoom.Show();
        }
        /**
         * Tạo màng hình chọn suất chiếu
         */
        public void Load_ScheduleScreen()
        {
            frmFilms.Visible = false;
            frmSchedule = new ScheduleList();
            frmSchedule.MdiParent = this;
            frmSchedule.Show();
        }

        /*Sự kiện click*/

        /**
         * Click chọn ngày
         */
        public void btnday_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            dayIndex = Convert.ToInt32(btn.Name.Substring(8));

            Load_Films(dayIndex);
        }
        /**
          * Sự kiện chuyên qua trang xác nhận
          */
        private void btnNext_Click(object sender, EventArgs e)
        {
            ticketID = frmRoom.ticketID;
            strl = frmRoom.strl;
            frmRoom.Visible = false;
            string str = "";
            string str1 = "";
            //load seat
            strl.ForEach(item =>
            {
                str += item + " ";
            });
            //load idseat
            ticketID.ForEach(item =>
            {
                str1 += item + " ";
            });
            frmConfirmTicket = new ConfirmTicket(str,str1);
            frmConfirmTicket.MdiParent = this;
            frmConfirmTicket.lblRoom.Text = Room_Name;
            frmConfirmTicket.lblSchedule.Text = sche_Name;
            frmConfirmTicket.Show();


        }

        /**
         * Click chọn phim
         */
        private void Schedule_Load(object sender, EventArgs e)
        {
            TileView tileView = sender as TileView;
            int fId = Convert.ToInt32(tileView.GetRowCellValue(tileView.FocusedRowHandle, "id_F").ToString());
            int filmsIndex = dates[dayIndex].films.FindIndex(item => item.id_F == fId);

            Load_ScheduleScreen();
            Load_Schedules(dayIndex, filmsIndex);
        }

        /**
         * Click chọn lịch chiếu
         */
        private void Load_Booking(object sender, EventArgs e)
        {
            TileView tileView = sender as TileView;
            sche_Id = Convert.ToInt32(tileView.GetRowCellValue(tileView.FocusedRowHandle, "id_Sche").ToString());
            sche_Name = tileView.GetRowCellValue(tileView.FocusedRowHandle, "StartTime").ToString();
            Room_Name = new RoomDAO().getRoomById(Convert.ToInt32(tileView.GetRowCellValue(tileView.FocusedRowHandle, "id_R").ToString())).R_Name;
            LoadRoom(sche_Id, Room_Name);
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
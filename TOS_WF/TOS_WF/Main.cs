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
        public List<string> strl = new List<string>();
        public List<string> ticketID = new List<string>();
        public List<string> CinemaId = new List<string>();
        public int A_id { get; set; }
        //public string username { get; set; }
        //public string password { get; set; }
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
        public int id_F { get; set; }
        public int id_B { get; set; }
        public String F_Name { get; set; }
        public FilmList frmFilms { get; set; }
        public ScheduleList frmSchedule { get; set; }
        public frmRoom frmRoom { get; set; }
        public ConfirmTicket frmConfirmTicket { get; set; }
        public Login frmLogin { get; set; }
        public Areas frmAreas { get; set; }
        public Main frmMain { get; set; }
        public frmTicket TicketN { get; set; }

        public Main()
        {
            InitializeComponent();
            frmFilms = new FilmList();
            frmSchedule = new ScheduleList();
            frmRoom = new frmRoom();
            frmLogin = new Login();
            frmAreas = new Areas();
            TicketN = new frmTicket();
            frmConfirmTicket = new ConfirmTicket();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }
        /**
         * Sự kiện ấn vào nút đăng nhập
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = frmLogin.txtUsername.Text;
            String password = frmLogin.txtPassword.Text;
            Console.WriteLine(username);
            Console.WriteLine(password);
            LoginDAO ldao = new LoginDAO();
            //Theater theater = new Theater(1);
            bool isLogin = ldao.Login(username, password);

            Console.WriteLine(isLogin);
            if (isLogin)
            {
                this.pnlBtnDate.Show();
                frmLogin.Visible = false;
                this.btnLogout.Visible = true;
                Load_Cinema(id_C);
                Load_Dates();
                Load_FilmsScreen();
                Load_Films(0);
            }
            else
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                MessageBox.Show("Wrong username or password", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmLogin.Visible = true;
            }
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
            try
            {
                frmFilms.FilmsList.DataSource = dates[dayIndex].films;
            }
            catch (Exception e)
            {

            }
        }

        /**
         * Load các lịch chiếu của 1 phim
         */
        public void Load_Schedules(int dayIndex, int filmsIndex)
        {
            frmSchedule.btnback.Click += new EventHandler(this.btnBack2_Click);
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
        public void LoadAreas()
        {
            frmAreas = new Areas();
            frmAreas.MdiParent = this;
            frmAreas.cbArea.DataSource = new AreaDAO().getAllArea();
            frmAreas.cbArea.SelectedIndexChanged += new EventHandler(this.cbCinema_SelectedIndexChanged);
            frmAreas.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);
            frmAreas.Show();
        }
        public void cbCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            A_id = Convert.ToInt32(frmAreas.cbArea.SelectedValue);
            frmAreas.cbCinema.Text = "";
            frmAreas.cbCinema.DataSource = new CinemaDAO().GetAllCinemasByAId(A_id);
            frmAreas.btnSubmit.Enabled = true;
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            id_C = Convert.ToInt32(frmAreas.cbCinema.SelectedValue);
            C_Name = frmAreas.cbCinema.Text;
            Console.WriteLine(C_Name);
            Login();
        }

        public void Login()
        {
            frmLogin = new Login();
            frmLogin.MdiParent = this;
            frmLogin.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            frmLogin.Show();
        }

        public void LoadRoom(int sche_Id, string Room_Name)
        {
            frmSchedule.Visible = false;
            frmRoom = new frmRoom(sche_Id, Room_Name);
            frmRoom.MdiParent = this;
            frmRoom.pbNext.Click += new EventHandler(this.btnNext_Click);
            frmRoom.pbBack.Click += new EventHandler(this.btnBack_Click);
            frmRoom.Show();
        }
        /**
         * Tạo màn hình chọn suất chiếu
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


            BillDAO bill = new BillDAO();

            frmConfirmTicket = new ConfirmTicket(str, str1);
            frmConfirmTicket.MdiParent = this;

            frmConfirmTicket.lblCinema.Text = C_Name;
            frmConfirmTicket.lblRoom.Text = Room_Name;
            frmConfirmTicket.lblSchedule.Text = sche_Name;
            frmConfirmTicket.lblFname.Text = F_Name;
            frmConfirmTicket.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            frmConfirmTicket.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            frmConfirmTicket.Show();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            strl.Clear();
            ticketID.Clear();
            strl.ForEach(item =>
            {
                Console.WriteLine(item + " ");
                
            });
            ticketID.ForEach(item =>
            {
                Console.WriteLine(item + " ");

            });

            frmRoom.Visible = false;
            frmSchedule.Show();
        }
        private void btnBack2_Click(object sender, EventArgs e)
        {
            strl.Clear();
            ticketID.Clear();
            frmSchedule.Visible = false;
            frmFilms.Show();
        }


        /**
         * Click chọn phim
         */
        private void Schedule_Load(object sender, EventArgs e)
        {
            TileView tileView = sender as TileView;
            id_F = Convert.ToInt32(tileView.GetRowCellValue(tileView.FocusedRowHandle, "id_F").ToString());
            F_Name = tileView.GetRowCellValue(tileView.FocusedRowHandle, "F_Name").ToString();

            int filmsIndex = dates[dayIndex].films.FindIndex(item => item.id_F == id_F);
            Load_ScheduleScreen();
            Load_Schedules(dayIndex, filmsIndex);
        }

        /**
         *Click Thanh toan
         */
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            frmConfirmTicket.Visible = false;
            string str = "";
            string str1 = "";
            //load seat
            strl.ForEach(item =>
            {
                str += item + " ";
            });
            //load idseat


            BillDAO bill = new BillDAO();
            BillDetailDAO bd = new BillDetailDAO();
            bill.CreateBill(1, 1, frmConfirmTicket.lblTotal.Text);
            //this.Visible = false;
            int getvalue = bill.getMaxIdBill();
            ticketID.ForEach(item =>
            {
                bd.CreateBillDetail(Convert.ToInt32(item), getvalue);
                str1 += item + " ";
                new TicketDAO().changeStatusTicket(Convert.ToInt32(item));
            });



            //this.Visible = false;

            Console.WriteLine(str);
            Console.WriteLine(str1);
            TicketN = new frmTicket(str, str1);
            TicketN.MdiParent = this;
            TicketN.lblBillId.Text = getvalue.ToString();
            TicketN.lblCinema.Text = C_Name;
            TicketN.lblRoom.Text = Room_Name;
            TicketN.lblSchedule.Text = sche_Name;
            TicketN.lblFName.Text = F_Name;
            TicketN.Show();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmConfirmTicket.Visible = false;
            frmRoom.Show();
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
            LoadAreas();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.strl.Clear();
                this.ticketID.Clear();
                this.CinemaId.Clear();
                this.A_id = 0;
                this.Sche_id = 0;
                id_C = 0;
                C_Name = "";
                id_Cus = 0;
                id_Staff = 0;
                dayIndex = 0;
                filmsIndex = 0;
                sche_Id = 0;
                sche_Name = "";
                room_Id = 0;
                billTotalPrice = 0;
                id_F = 0;
                id_B = 0;
                Main main = new Main();
                pnlBtnDate.Controls.Clear();
                frmSchedule.Dispose();
                this.pnlBtnDate.Hide();
                frmConfirmTicket.Dispose();
                frmFilms.Dispose();
                frmRoom.Dispose();
                this.frmAreas.Visible = true;
                this.btnLogout.Hide();
            }
            catch (Exception)
            {

            }

        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }
    }



}
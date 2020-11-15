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
    public partial class frmRoom : DevExpress.XtraEditors.XtraForm
    {

        int dem = 0;
        int tempprice = 0;
        public static List<string> strl = new List<string>();
        public static List<string> ticketID = new List<string>();
        public int Sche_id { get; set; }

        public frmRoom(int Sche_id, string r_Name)
        {
            this.Sche_id = Sche_id;
            InitializeComponent();
            this.lblRoom.Text = r_Name;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            this.pnlRoomSeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            CreateSeat();
        }
        public frmRoom()
        {
            InitializeComponent();
        }



        private void CreateSeat()
        {
            List<Ticket> t = new List<Ticket>();
            TicketDAO tDAO = new TicketDAO();
            t = tDAO.GetAllTicket(Sche_id);//load by id lich chieu
            Point[] p = new Point[t.Count]; //vi tri x,y cua 1 nut
            Button[] btn = new Button[t.Count];//so luong nut 
            int row = t[0].R_Row;//so hang
            int col = t[0].R_Col;//so cot
            tempprice = t[0].T_Price;
            pnlSeat.Size = new Size(55 * (col + 1), 40 * (row + 1)); //dai,rong
            //tim gia tri lon nhat
            for (int i = 0; i < t.Count; i++)
            {
                if (t[i].T_Price > tempprice)
                {
                    tempprice = t[i].T_Price;
                }
            }

            for (int j = 0; j < row; j++)
            {
                for (int z = 0; z < col; z++)
                {

                    int price = t[j * col + z].T_Price;
                    btn[j * col + z] = new Button();
                    btn[j * col + z].Height = 35;
                    btn[j * col + z].Width = 50;
                    btn[j * col + z].Text = t[j * col + z].T_Name; ;
                    btn[j * col + z].Name = "" + (t[j * col + z].id_T);
                    p[j * col + z] = new Point();
                    p[j * col + z].X = j * col + z * 90;
                    p[j * col + z].Y = 0;
                    if (price == tempprice)
                    {
                        btn[j * col + z].BackColor = Color.Red;//ghe co gia dac biet

                    }

                    if (t[j * col + z].Status == 0)
                    {
                        btn[j * col + z].BackColor = Color.Gray;//ghe da duoc chon
                        btn[j * col + z].Enabled = false;//ghe da duoc chon
                    }

                    //log += p.ToString() + "\n";
                    btn[j * col + z].PointToClient(p[j * col + z]);//tinh toan toa do voi cac may khac nhau
                    btn[j * col + z].Show();//hien thi cho nguoi dung 
                    btn[j * col + z].Click += new EventHandler(this.btn_Click);

                }
            }

            pnlSeat.Controls.AddRange(btn);//add vao panel cac button 

        }



        public void btn_Click(object sender, EventArgs e)
        {
            //Bat su kien click nut
            Button btn = sender as Button;
            string str = "";
            if (strl.FindIndex(x => x.Equals(btn.Text)) == -1)
            {
                if (dem < 8)
                {
                    strl.Add(btn.Text);
                    ticketID.Add(btn.Name);
                    btn.BackColor = Color.Yellow;//da chon ghe
                    //pbNext.Enabled = true;
                   
                    dem++;
                    if (dem > 0)
                    {
                        pbNext.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("You can only choose up to 8 seats", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                int getprice = new TicketDAO().GetMaxValue(Convert.ToInt32(btn.Name));
                if (getprice == tempprice)
                {

                    btn.BackColor = Color.Red;//chua chon ghe dac biet
                }
                else
                {

                    btn.BackColor = Color.White;//chua chon
                }
                //pbNext.Enabled = false;
               
                dem--;
                strl.Remove(btn.Text);
                ticketID.Remove(btn.Name);
                if (dem == 0)
                {
                    pbNext.Visible = false;
                }
            }
            strl.ForEach(item =>
            {
                str += item + " ";
            });
            txtShowSeat.Text = str;


        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            strl.Clear();
            ticketID.Clear();
        }
    }
}
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
        //string str="";
        public static List<string> strl = new List<string>();

        public frmRoom()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            CreateSeat();
        }



        private void CreateSeat()
        {
            List<Ticket> t = new List<Ticket>();
            TicketDAO tDAO = new TicketDAO();
            t = tDAO.GetAllTicket(18);//load by id lich chieu
            Point[] p = new Point[t.Count]; //vi tri x,y cua 1 nut
            Button[] btn = new Button[t.Count];//so luong nut 
            Console.WriteLine(t.Count);
            int row = t[0].R_Row;//so hang
            int col = t[0].R_Col;//so cot
          
            pnlSeat.Size = new Size(55* (col+1), 40* (row+1)); //dai,rong
            for (int j = 0; j < row; j++)
                {
                    for (int z = 0; z < col; z++)
                    {
                   
                        btn[j*col+z] = new Button();
                        btn[j * col + z].Height = 35;
                        btn[j * col + z].Width = 50;

                        btn[j * col + z].Text = t[j * col + z].T_Name; ;
                        btn[j * col + z].Name = "btn_" + t[j * col + z].T_Name;
                        p[j * col + z] = new Point();
                        p[j * col + z].X = j * col + z * 90;

                        p[j * col + z].Y = 0 ;

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
                    btn.BackColor = Color.Yellow;//doi mau button da chon 2 lan
                    dem++;
                }
                else
                {
                    MessageBox.Show("You can only choose up to 8 seats", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                btn.BackColor = Color.White;//doi mau button da chon 2 lan
                dem--;
                strl.Remove(btn.Text);
            }
            strl.ForEach(item =>
            {
                str += item + " ";
            });
            txtShowSeat.Text = str;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void lblScreen_Click(object sender, EventArgs e)
        {

        }
    }
}
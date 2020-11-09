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
using System.Collections;

/**
 * TIEU HA ANH KHOI - CE140252
 */
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
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red300, MaterialSkin.Primary.Red900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            CreatSeat();
        }

        private void CreatSeat()
        {
            Point[] p = new Point[100]; //vi tri x,y cua 1 nut
            //string log = "";

            Button[] btn = new Button[100];//so luong nut 
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                btn[i] = new Button();
                btn[i].Height = 65;
                btn[i].Width = 80;
                btn[i].Text = i.ToString();
                btn[i].Name = "btn_" + i.ToString();
                p[i] = new Point();
                p[i].X = i * 90;

                p[i].Y = 0;

                //log += p.ToString() + "\n";
                btn[i].PointToClient(p[i]);//tinh toan toa do voi cac may khac nhau
                btn[i].Show();//hien thi cho nguoi dung 
                btn[i].Click += new EventHandler(this.btn_Click);
            }

            pnlSeat.Controls.AddRange(btn);//add vao panel cac button 

        }
        public static void AddSeat(string seatName)
        {

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


    }
}
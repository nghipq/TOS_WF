using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOS_WF.DAO
{
    class BillDAO
    {
        private MySqlConnection conn { get; set; }

        public BillDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }

        public int CreateBill(int id_Cus, int id_Staff, long Total)
        {
            int result = 0;
            using (conn)
            {
                try
                {
                    conn.Open();
                    string insertData = "INSERT INTO Bill(id_Cus, id_Staff, Total, Status) values (@id_Cus, @id_Staff, @Total, @Status)";
                    MySqlCommand command = new MySqlCommand(insertData);
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@id_Cus", id_Cus);
                    command.Parameters.AddWithValue("@id_Staff", id_Staff);
                    command.Parameters.AddWithValue("@Total", Total);
                    command.Parameters.AddWithValue("@Status", 1);
                    result = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to database due to" + ex.ToString());
                    MessageBox.Show("Failed to insert data due to" + ex.ToString());
                }

            }
            conn.Close();


            return getMaxIdBill();
        }
        public int getMaxIdBill()
        {
            int getvalue = 0;
            string sql = "SELECT MAX(id_B) as id_B FROM Bill";
            using (conn)
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                //command.Connection = conn;
                conn.Open();
                MySqlDataReader md = command.ExecuteReader();
                if (md.Read())
                {
                    getvalue = Convert.ToInt32(md["id_B"]);
                }
            }
            conn.Close();
            return getvalue;
        }
    }
}

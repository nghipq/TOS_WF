using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class BillDetailDAO
    {
        private MySqlConnection conn { get; set; }
        public BillDetailDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }
        public int CreateBillDetail(int id_T, int id_B, Boolean Status)
        {
            int result = 0;
            using (conn)
            {
                conn.Open();
                string sql = "INSERT INTO BillDetail(id_T, id_B, Status) VALUES (@id_T,@id_B,@Status)";
                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.AddWithValue("@id_T", id_T);
                command.Parameters.AddWithValue("@id_B", id_B);
                command.Parameters.AddWithValue("@Status", Status);
                result = command.ExecuteNonQuery();
                conn.Close();
            }
            conn.Close();
            return result;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class UserDAO
    {
        private MySqlConnection conn { get; set; }
        public UserDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }
        public User getUserByName(String Username)
        {

            User cm = null;
            using (conn)
            {

                string sql = "SELECT * FROM User WHERE Username = @Username";
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;
                com.Parameters.AddWithValue("@Username", Username);
                conn.Open();

                MySqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    cm = new User
                    {
                        id_U = Convert.ToInt32(dr["id_U"]),
                        Username = dr["Username"].ToString(),
                        Address = dr["Address"].ToString(),
                        Email = dr["Email"].ToString(),
                        Phone = dr["Phone"].ToString(),
                        Birthday = Convert.ToDateTime(dr["Birthday"]),
                        Status = Convert.ToInt32(dr["Status"]),
                        Gender = Convert.ToInt32(dr["Gender"]),
                        id_N = Convert.ToInt32(dr["id_N"]),
                        RegisDate = Convert.ToDateTime(dr["RegisDate"]),
                        Permission = Convert.ToInt32(dr["Permission"]),
                        Password = dr["Password"].ToString()
                    };
                }

                //đóng db sau khi dùng xong nhe
                conn.Close();
            }
            return cm;
        }

    }
}

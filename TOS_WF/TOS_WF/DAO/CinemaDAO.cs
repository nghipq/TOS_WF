using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class CinemaDAO
    {
        public MySqlConnection conn { get; set; }
        public CinemaDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }
        public List<Cinema> GetAllCinemasByAId(int A_id)
        {
            List<Cinema> cList = new List<Cinema>();
            using (conn)
            {
                string sql = "SELECT `id_C`, `C_Name`,`Status`FROM `cinema` WHERE A_Id="+A_id;
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;

                conn.Open();

                MySqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    cList.Add(new Cinema
                    {
                        Id_C = Convert.ToInt32(dr["id_C"]),
                        C_Name = dr["C_Name"].ToString(),
                        Status = Convert.ToInt32(dr["Status"]),
                    });
                }

                //đóng db sau khi dùng xong nhe
                conn.Close();
            }

            return cList;
        }
    }
}

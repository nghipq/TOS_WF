using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class AreaDAO
    {
        public MySqlConnection conn { get; set; }
        public AreaDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }
        public List<Area> getAllArea()
        {
            List<Area> aList = new List<Area>();
            using (conn)
            {
                string sql = "select * from Areas";
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;

                conn.Open();

                MySqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    aList.Add(new Area
                    {
                        A_Id = Convert.ToInt32(dr["A_Id"]),
                        A_Name = dr["A_Name"].ToString(),
                        Status = Convert.ToBoolean(dr["Status"]),
                    });
                }

                //đóng db sau khi dùng xong nhe
                conn.Close();
            }

            return aList;
        }
    }
}

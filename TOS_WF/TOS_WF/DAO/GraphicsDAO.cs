using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class GraphicsDAO
    {
        private MySqlConnection conn { get; set; }

        public GraphicsDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }

        public Graphics getLastPosterInFilm(int id_F)
        {

            using (conn)
            {
                string sql = "SELECT * FROM Graphics where id_F = @id_F and G_Type = 1 and Status = 1 order by id_G desc";
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;
                com.Parameters.AddWithValue("@id_F", id_F);

                conn.Open();

                MySqlDataReader dr = com.ExecuteReader();

                Graphics g = null;

                if (dr.Read())
                {
                    g = new Graphics
                    {
                        id_G = Convert.ToInt32(dr["id_G"]),
                        id_F = Convert.ToInt32(dr["id_F"]),
                        G_Type = Convert.ToInt32(dr["G_Type"]),
                        DateUpdate = Convert.ToDateTime(dr["DateUpdate"]),
                        Path = dr["Path"].ToString(),
                        Status = Convert.ToInt32(dr["Status"]),
                    };
                }

                //đóng db sau khi dùng xong nhe
                conn.Close();
                return g;
            }
        }
    }
}

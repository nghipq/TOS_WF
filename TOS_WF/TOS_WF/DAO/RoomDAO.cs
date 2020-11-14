using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class RoomDAO
    {
        private MySqlConnection conn { get; set; }

        public RoomDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }

        public Room getRoomById(int r_id)
        {
            Room room = null;
            string sql = "select * from Room where id_R = @id_R";
            using(conn)
            {
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;
                conn.Open();

                com.Parameters.AddWithValue("@id_R", r_id);

                MySqlDataReader dr = com.ExecuteReader();

                if(dr.Read())
                {
                    room = new Room
                    {
                        id_R = r_id,
                        R_Name = dr["R_Name"].ToString(),
                    };
                }
                conn.Close();
            }

            return room;
        }
       
    }
    
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class ScheduleDAO
    {
        public MySqlConnection conn { get; set; }
        public ScheduleDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }

        public List<Schedule> getSchedulesByCinemaFilmTime(int id_C, int id_F, DateTime date)
        {
            using (conn)
            {
                List<Schedule> list = new List<Schedule>();
                conn.Open();
                string sql = "SELECT* FROM Schedule INNER JOIN Session ON Schedule.id_Ses = Session.id_Ses where id_C = @id_C and id_F = @id_F and Sche_Date = @Sche_Date ORDER BY Session.StartTime ASC";
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;
                com.Parameters.AddWithValue("@id_C", id_C);
                com.Parameters.AddWithValue("@id_F", id_F);
                com.Parameters.AddWithValue("@Sche_Date", date);

                MySqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Schedule
                    {
                        id_Sche = Convert.ToInt32(dr["id_Sche"]),
                        id_Ses = Convert.ToInt32(dr["id_Ses"]),
                        StartTime = TimeSpan.Parse(dr["StartTime"].ToString()),
                        id_C = Convert.ToInt32(dr["id_C"]),
                        id_F = Convert.ToInt32(dr["id_F"]),
                        id_R = Convert.ToInt32(dr["id_R"]),
                        Status = Convert.ToInt32(dr["Status"]),
                        Sche_Date = Convert.ToDateTime(dr["Sche_Date"]),
                    });
                }
                conn.Close();

                return list;
            }
        }
    }
}

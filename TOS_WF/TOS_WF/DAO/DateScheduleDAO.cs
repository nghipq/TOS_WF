using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class DateScheduleDAO
    {
        private MySqlConnection conn { get; set; }

        public DateScheduleDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }

        public List<DateSchedule> getDateScheduleByCinema(int id_C)
        {
            List<DateSchedule> dateSchedules = new List<DateSchedule>();

            using (conn)
            {
                string sql = "SELECT DISTINCT Sche_Date FROM Schedule WHERE Sche_Date >= CURRENT_DATE and id_C = @id_C ORDER BY Sche_Date ASC";
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;
                com.Parameters.AddWithValue("@id_C", id_C);

                conn.Open();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    dateSchedules.Add(new DateSchedule
                    {
                        dateSchedule = Convert.ToDateTime(dr["Sche_Date"])
                    });
                }

                conn.Close();
                dateSchedules.ForEach(item =>
                {
                    item.films = new FilmDAO().getFilmByCinemaAndDate(id_C, item.dateSchedule);
                });
            }

            return dateSchedules;
        }
    }
}

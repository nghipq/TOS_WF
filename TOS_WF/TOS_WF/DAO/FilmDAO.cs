using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class FilmDAO
    {
        private MySqlConnection conn { get; set; }

        public FilmDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }

        public List<Films> getAllFilm()
        {
            List<Films> Flist = new List<Films>();
            using (conn)
            {
                string sql = "select * from Films INNER JOIN `Producers` ON Films.id_P=Producers.id_P where Films.Status > 0";
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;

                conn.Open();

                MySqlDataReader dr = com.ExecuteReader();

                GraphicsDAO gDAO = new GraphicsDAO();

                while (dr.Read())
                {
                    int id_F = Convert.ToInt32(dr["id_F"]);

                    Graphics g = gDAO.getLastPosterInFilm(Convert.ToInt32(dr["id_F"]));
                    Flist.Add(new Films
                    {
                        id_F = id_F,
                        F_Name = dr["F_Name"].ToString(),
                        id_P = Convert.ToInt32(dr["id_P"]),
                        ReleaseDate = Convert.ToDateTime(dr["ReleaseDate"]),
                        Description = dr["Description"].ToString(),
                        Rating = Convert.ToDouble(dr["Rating"]),
                        LimitAge = Convert.ToInt32(dr["LimitAge"]),
                        AirDate = Convert.ToDateTime(dr["AirDate"]),
                        EndDate = Convert.ToDateTime(dr["EndDate"]),
                        Status = Convert.ToInt32(dr["status"]),
                        Poster = (g != null) ? g.Path : "empty.jpg",
                        F_Trailer = dr["F_Trailer"].ToString(),
                        F_Time = Convert.ToInt32(dr["F_Time"])
                    });
                }

                //đóng db sau khi dùng xong nhe
                conn.Close();
                Flist.ForEach(item =>
                {
                    item.Categories = new CategoryDAO().ListCategoryInFilm(item.id_F);
                });
            }

            return Flist;
        }
        public Films getFilmById(int id_F)
        {
            Films film = null;
            using (conn)
            {
                string query = "SELECT `F_Name` FROM `films` WHERE id_F=@id_F";

                MySqlCommand command = new MySqlCommand(query);
                command.Connection = conn;
                conn.Open();
                command.Parameters.AddWithValue("@id_F", id_F);
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {

                    film = new Films
                    {
                        id_F = id_F,
                        F_Name = dr["F_Name"].ToString()
                    };
                }

            }

            conn.Close();
            return film;
        }

        public List<Films> getFilmByCinemaAndDate(int id_C, DateTime date)
        {
            List<Films> Flist = new List<Films>();
            ScheduleDAO scheDAO = new ScheduleDAO();
            using (conn)
            {
                string sql = "SELECT DISTINCT Films.id_F, F_Name, id_P, ReleaseDate, Description, Rating, LimitAge, AirDate, EndDate, Films.Status FROM Films INNER JOIN Schedule ON Films.id_F = Schedule.id_F where Schedule.id_C=@id_C and Schedule.Sche_Date= @Sche_Date and Films.Status > 0";
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;

                com.Parameters.AddWithValue("@id_C", id_C);
                com.Parameters.AddWithValue("@Sche_Date", date);

                conn.Open();

                MySqlDataReader dr = com.ExecuteReader();

                GraphicsDAO gDAO = new GraphicsDAO();

                while (dr.Read())
                {
                    int id_F = Convert.ToInt32(dr["id_F"]);

                    Graphics g = gDAO.getLastPosterInFilm(Convert.ToInt32(dr["id_F"]));
                    Flist.Add(new Films
                    {
                        id_F = id_F,
                        F_Name = dr["F_Name"].ToString(),
                        id_P = Convert.ToInt32(dr["id_P"]),
                        ReleaseDate = Convert.ToDateTime(dr["ReleaseDate"]),
                        Description = dr["Description"].ToString(),
                        Rating = Convert.ToDouble(dr["Rating"]),
                        LimitAge = Convert.ToInt32(dr["LimitAge"]),
                        AirDate = Convert.ToDateTime(dr["AirDate"]),
                        EndDate = Convert.ToDateTime(dr["EndDate"]),
                        Status = Convert.ToInt32(dr["status"]),
                        Poster = (g != null) ? g.Path : "empty.jpg",
                    });
                }

                //đóng db sau khi dùng xong nhe
                conn.Close();
                Flist.ForEach(item =>
                {
                    item.Schedules = scheDAO.getSchedulesByCinemaFilmTime(id_C, item.id_F, date);
                });
            }

            return Flist;
        }
    }
}

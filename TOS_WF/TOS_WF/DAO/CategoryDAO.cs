using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class CategoryDAO
    {
        private MySqlConnection conn { get; set; }

        public CategoryDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }

        public List<Categories> ListCategoryInFilm(int id_F)
        {
            List<Categories> cateList = new List<Categories>();
            using (conn)
            {
                string sql = "SELECT * FROM CategoryInFilm INNER JOIN Categories ON CategoryInFilm.id_Cate = Categories.id_Cate WHERE CategoryInFilm.id_F = @id_F";
                MySqlCommand com = new MySqlCommand(sql);
                com.Connection = conn;
                conn.Open();
                com.Parameters.AddWithValue("@id_F", id_F);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cateList.Add(new Categories
                    {
                        id_Cate = Convert.ToInt32(dr["id_Cate"]),
                        Cate_Name = dr["Cate_Name"].ToString(),
                        Description = dr["Description"].ToString(),
                        Status = Convert.ToBoolean(true),
                    });
                }
                //đóng db sau khi dùng xong nhe
                conn.Close();
            }
            return cateList;
        }
    }
}

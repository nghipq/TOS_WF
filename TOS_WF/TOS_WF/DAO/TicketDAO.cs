using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOS_WF.Models;

namespace TOS_WF.DAO
{
    class TicketDAO
    {
        private MySqlConnection conn { get; set; }

        public TicketDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }
        public List<Ticket> GetAllTicket(int id_Sche)
        {
            List<Ticket> TicketList = new List<Ticket>();
            using (conn)
            {
                string query = "SELECT * FROM Ticket INNER JOIN Schedule ON Ticket.id_Sche = Schedule.id_Sche INNER JOIN Room ON Schedule.id_R = Room.id_R WHERE Schedule.id_Sche = @id_Sche and Ticket.Status < 2";

                MySqlCommand command = new MySqlCommand(query);
                command.Connection = conn;
                conn.Open();
                command.Parameters.AddWithValue("@id_Sche", id_Sche);
                MySqlDataReader md = command.ExecuteReader();
                while (md.Read())
                {
                    TicketList.Add(
                        new Ticket
                        {
                            id_T = Convert.ToInt32(md["id_T"]),
                            id_Sche = Convert.ToInt32(md["id_Sche"]),
                            T_Name = md["T_Name"].ToString(),
                            T_Price = Convert.ToInt32(md["T_Price"]),
                            id_Ses = Convert.ToInt32(md["id_Ses"]),
                            id_F = Convert.ToInt32(md["id_F"]),
                            Status = Convert.ToInt32(md["Status"]),
                            Sche_Date = Convert.ToDateTime(md["Sche_Date"]),
                            id_C = Convert.ToInt32(md["id_C"]),
                            id_R = Convert.ToInt32(md["id_R"]),
                            R_SeatNumber = Convert.ToInt32(md["R_SeatNumber"]),
                            R_Size = Convert.ToInt32(md["R_Size"]),
                            R_Type = Convert.ToInt32(md["R_Type"]),
                            R_Row = Convert.ToInt32(md["R_Row"]),
                            R_Col = Convert.ToInt32(md["R_Col"]),
                            R_Name = md["R_Name"].ToString(),
                        });
                }
            }

            conn.Close();
            return TicketList;
        }


    }
}

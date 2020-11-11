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
       
    }
    
}

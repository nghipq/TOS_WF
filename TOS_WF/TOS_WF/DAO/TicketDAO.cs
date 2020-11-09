using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOS_WF.DAO
{
    class TicketDAO
    {
        private MySqlConnection conn { get; set; }

        public TicketDAO()
        {
            this.conn = new DBConnection.DBConnection().conn;
        }

        
    }
}

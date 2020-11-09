using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOS_WF.DBConnection
{
    class DBConnection
    {
        public MySqlConnection conn { get; set; }

        public DBConnection()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Mysqlconnection"].ConnectionString;

            this.conn = new MySqlConnection(mainconn);
        }
    }
}

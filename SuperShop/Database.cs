using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperShop
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = @"Server=DESKTOP-FSD94S9;Database=SuperShop;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}

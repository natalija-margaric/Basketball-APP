using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BB_app.Model.DB
{
    public static class DB_connection
    {

        private static string conn_string = "URI=file:database.db";
        internal static SQLiteConnection conn = new SQLiteConnection(conn_string);
        //open connection
        internal static void OpenConn()
        {
            conn.Open();
        }
        //close connection
        internal static void CloseConn()
        {
            conn.Close();
        }
 
    }
}

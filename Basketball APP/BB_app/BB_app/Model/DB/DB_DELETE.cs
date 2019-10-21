using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BB_app.Model.DB
{
    static class DB_DELETE
    {
        public static void Delete_row(int id, string table)
        {
            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"DELETE FROM {0} WHERE ID = {1}", table, id.ToString());
            com.ExecuteNonQuery();//executes a non querry (vraca broj izvodenja)
            com.Dispose();//oslobodi resurse
        }
    }
}

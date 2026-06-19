using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace PocketLedger.Database
{

internal class DbConnection
    {
        private static string connStr =
        "server=localhost;user=root;password=2419624196;database=pocketledgerdb;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}

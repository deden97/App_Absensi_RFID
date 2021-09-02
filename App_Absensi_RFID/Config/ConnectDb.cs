using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace App_Absensi_RFID.Config
{
    public sealed class ConnectDb
    {
        private static string sc = "LAPTOP-D7CCRR4J";
        private static string db = "DB_APP_ABSENSI_RFID";

        public static SqlConnection GetConnection()
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = $"Data Source = {sc}; initial catalog = {db}; integrated security = true";
            return sqlCon;
        }
    }
}
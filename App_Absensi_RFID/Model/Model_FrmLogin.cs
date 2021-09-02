//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace App_Absensi_RFID.Model
{
    public class Model_FrmLogin
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlDr;
        private SqlDataAdapter sqlDa;
        private string query;

        protected Model_FrmLogin() => this.sqlCon = Config.ConnectDb.GetConnection();

        protected bool Login(string username, string password)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "SELECT KODE_ADMIN FROM TB_AKUN_ADMIN " +
                             $"WHERE USERNAME = '{username}' AND PASSWORD_AKUN = '{password}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDr = this.sqlCmd.ExecuteReader();
                return this.sqlDr.Read();
            }
            finally
            { 
                this.sqlCon.Close();
                this.sqlDr.Close();
            }
        }

        protected DataTable GetDataAdmin(string username, string password)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "SELECT TB_AKUN_ADMIN.KODE_ADMIN, TB_ADMIN.NAMA, TB_ADMIN.FOTO " +
                             "FROM TB_AKUN_ADMIN INNER JOIN TB_ADMIN " +
                             "ON TB_AKUN_ADMIN.KODE_ADMIN = TB_ADMIN.KODE_ADMIN " +
                             $"WHERE USERNAME = '{username}' AND PASSWORD_AKUN = '{password}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDa = new SqlDataAdapter(this.sqlCmd);
                DataTable dt = new DataTable();
                this.sqlDa.Fill(dt);
                return dt;
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlDr.Close();
            }
        }
    }
}
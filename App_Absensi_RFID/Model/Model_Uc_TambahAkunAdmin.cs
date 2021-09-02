//using System;
//using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.Model
{
    public class Model_Uc_TambahAkunAdmin
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlDr;
        private string query;

        protected Model_Uc_TambahAkunAdmin() => this.sqlCon = Config.ConnectDb.GetConnection();

        protected bool SelectUsername(string username)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT USERNAME FROM TB_AKUN_ADMIN WHERE USERNAME = '{username}'";
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

        protected int JumlahAdmin()
        {
            int row = 0;
            try
            {
                this.sqlCon.Open();
                this.query = "SELECT KODE_ADMIN FROM TB_AKUN_ADMIN";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDr = this.sqlCmd.ExecuteReader();
                while (this.sqlDr.Read())
                    row++;
                return row;
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlDr.Close();
            }
        }
        
        protected int InsertAdmin(object kodeAdmin, object nama, object jk, object noHp, byte[] foto)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "EXEC PROC_INSERT_ADMIN @KODE_ADMIN, @NAMA, @JK, @NO_HP, @FOTO";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@KODE_ADMIN", kodeAdmin);
                this.sqlCmd.Parameters.AddWithValue("@NAMA", nama);
                this.sqlCmd.Parameters.AddWithValue("@JK", jk);
                this.sqlCmd.Parameters.AddWithValue("@NO_HP", noHp);
                this.sqlCmd.Parameters.AddWithValue("@FOTO", foto);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally { this.sqlCon.Close(); }
        }

        protected int InsertAkunAdmin(object kodeAdmin, object username, object password)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "EXEC PROC_INSERT_AKUN_ADMIN @KODE_ADMIN, @USERNAME, @PASSWORD";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@KODE_ADMIN", kodeAdmin);
                this.sqlCmd.Parameters.AddWithValue("@USERNAME", username);
                this.sqlCmd.Parameters.AddWithValue("@PASSWORD", password);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally { this.sqlCon.Close(); }
        }
    }
}
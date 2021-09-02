//using System;
//using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.Model
{
    public class Model_Uc_EditDataAdmin
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlDr;
        private SqlDataAdapter sqlDa;
        private DataTable dt;
        private string query;

        protected Model_Uc_EditDataAdmin() => this.sqlCon = Config.ConnectDb.GetConnection();

        protected DataTable GetDataAdmin(object kodeAdmin)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT * FROM TB_ADMIN WHERE KODE_ADMIN = '{kodeAdmin.ToString()}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDa = new SqlDataAdapter(this.sqlCmd);
                this.dt = new DataTable();
                this.sqlDa.Fill(this.dt);
                return this.dt;
            }
            finally { this.sqlCon.Close(); }
        }

        protected int UpdataDataAdmin(object kodeAdmin, object nama, object jenisKelamin, object noHp, byte[] foto)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "EXEC PROC_UPDATE_DATA_ADMIN @KODE_ADMIN, @NAMA, @JK, @NO_HP, @FOTO";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@KODE_ADMIN", kodeAdmin);
                this.sqlCmd.Parameters.AddWithValue("@NAMA", nama);
                this.sqlCmd.Parameters.AddWithValue("@JK", jenisKelamin);
                this.sqlCmd.Parameters.AddWithValue("@NO_HP", noHp);
                this.sqlCmd.Parameters.AddWithValue("@FOTO", foto);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally { this.sqlCon.Close(); }
        }

        protected object[] GetUsername(object kodeAdmin)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT KODE_ADMIN, USERNAME FROM TB_AKUN_ADMIN WHERE KODE_ADMIN = '{kodeAdmin}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDr = this.sqlCmd.ExecuteReader();
                this.sqlDr.Read();
                return new object[] { this.sqlDr.GetValue(0), this.sqlDr.GetValue(1)};
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlDr.Close();
            }
        }

        protected bool CekUsernameBaru(object usernameBaru)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT USERNAME FROM TB_AKUN_ADMIN WHERE USERNAME = '{usernameBaru}'";
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

        protected int UpdateUsername(object kodeAdmin, object usernameBaru)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "UPDATE TB_AKUN_ADMIN SET USERNAME = @USERNAME_BARU WHERE KODE_ADMIN = @KODE_ADMIN";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@USERNAME_BARU", usernameBaru);
                this.sqlCmd.Parameters.AddWithValue("@KODE_ADMIN", kodeAdmin);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally { this.sqlCon.Close(); }
        }

        protected bool GetPassword(object kodeAdmin, object passwordSaatIni)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT KODE_ADMIN FROM TB_AKUN_ADMIN WHERE KODE_ADMIN = '{kodeAdmin}' AND PASSWORD_AKUN = '{passwordSaatIni}'";
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

        protected int UpdatePassword(object kodeAdmin, object passwordBaru, object passwordSaatIni)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "UPDATE TB_AKUN_ADMIN SET PASSWORD_AKUN = @PASSWORD_BARU " +
                             $"WHERE KODE_ADMIN = '{kodeAdmin}' AND PASSWORD_AKUN = '{passwordSaatIni}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@PASSWORD_BARU", passwordBaru);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally { this.sqlCon.Close(); }
        }
    }
}
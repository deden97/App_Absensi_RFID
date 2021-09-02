//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;

namespace App_Absensi_RFID.Model
{
    public class Model_Uc_TambahKaryawan
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlDr;
        private SqlDataAdapter sqlDa;
        private string query;

        protected Model_Uc_TambahKaryawan() => this.sqlCon = Config.ConnectDb.GetConnection();

        protected bool DbGetKodeKaryawan(object kodeKaryawan)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT KODE_KARYAWAN FROM TB_KARYAWAN WHERE KODE_KARYAWAN = '{kodeKaryawan}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDr = this.sqlCmd.ExecuteReader();
                return this.sqlDr.Read();
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlDr.Close();
                this.query = null;
            }
        }

        protected System.Data.DataTable DbGetJabatan()
        {
            try
            {
                this.sqlCon.Open();
                this.query = "SELECT * FROM TB_JABATAN";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDa = new SqlDataAdapter(this.sqlCmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                this.sqlDa.Fill(dt);
                return dt;
            }
            finally
            {
                this.sqlCon.Close();
                this.query = null;
            }
        }
        
        protected int DbinsertKaryawan(object kodeKaryawan, string terdaftar, string nama, string jk, string noHp, string jabatan, byte[] foto)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "EXEC PROC_INSERT_KARYAWAN @KODE_KARYAWAN, @TERDAFTAR, @NAMA, @JK, @NO_HP, @JABATAN, @FOTO";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@KODE_KARYAWAN", kodeKaryawan);
                this.sqlCmd.Parameters.AddWithValue("@TERDAFTAR", terdaftar);
                this.sqlCmd.Parameters.AddWithValue("@NAMA", nama);
                this.sqlCmd.Parameters.AddWithValue("@JK", jk);
                this.sqlCmd.Parameters.AddWithValue("@NO_HP", noHp);
                this.sqlCmd.Parameters.AddWithValue("@JABATAN", jabatan);
                this.sqlCmd.Parameters.AddWithValue("@FOTO", foto);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally
            {
                this.sqlCon.Close();
                this.query = null;
            }
        }
    }
}

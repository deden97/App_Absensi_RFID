//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;

namespace App_Absensi_RFID.Model
{
    public class Model_Uc_TambahJabatan
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlDr;
        private SqlDataAdapter sqlDa;
        private string query;

        protected Model_Uc_TambahJabatan() => this.sqlCon = Config.ConnectDb.GetConnection();

        protected bool DbCekKodeJabatan(string kodeJabatan)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT KODE_JABATAN FROM TB_JABATAN WHERE KODE_JABATAN = '{kodeJabatan}'";
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

        protected bool DbCekNamaJabatan(string namaJabatan)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT NAMA_JABATAN FROM TB_JABATAN WHERE NAMA_JABATAN = '{namaJabatan}'";
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

        protected int DbInsertJabatan(string kodeJabatan, string namaJabatan)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "INSERT INTO TB_JABATAN VALUES(@KODE_JABATAN, @NAMA_JABATAN)";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@KODE_JABATAN", kodeJabatan);
                this.sqlCmd.Parameters.AddWithValue("@NAMA_JABATAN", namaJabatan);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally
            {
                this.sqlCon.Close();
                this.query = null;
            }
        }

        protected System.Data.DataTable DbGetTbJabatan()
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
    }
}

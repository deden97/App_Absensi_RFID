//using System;
//using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.Model
{
    public class Model_EditJabatan
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlDr;
        private SqlDataAdapter sqlDa;
        private string query;

        protected Model_EditJabatan() => this.sqlCon = Config.ConnectDb.GetConnection();

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

        protected int DbDeleteJabatan(object kodeJabatan)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"DELETE TB_JABATAN WHERE KODE_JABATAN = '{kodeJabatan}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally
            {
                this.sqlCon.Close();
                this.query = null;
            }
        }

        protected int DbEditJabatan(object kodeJabatan, string namaJabatan)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"UPDATE TB_JABATAN SET NAMA_JABATAN = @BARU WHERE KODE_JABATAN = '{kodeJabatan}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@BARU", namaJabatan);
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

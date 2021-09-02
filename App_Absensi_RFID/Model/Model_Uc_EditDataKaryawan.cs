//using System;
//using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.Model
{
    public class Model_Uc_EditDataKaryawan
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlDr;
        private SqlDataAdapter sqlDa;
        private DataTable dt;
        private string query;

        protected Model_Uc_EditDataKaryawan() => this.sqlCon = Config.ConnectDb.GetConnection();

        protected bool DbSelectKodeKaryawan(string kodeKaryawan)
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
                this.sqlCmd.Dispose();
                this.query = null;
            }
        }

        protected DataTable DbGetDataKaryawan(string kodeKaryawan)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT * FROM TB_KARYAWAN WHERE KODE_KARYAWAN = '{kodeKaryawan}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDa = new SqlDataAdapter(this.sqlCmd);
                this.dt = new DataTable();
                this.sqlDa.Fill(this.dt);
                return this.dt;
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlDa.Dispose();
                this.query = null;
                this.dt.Dispose();
            }
        }

        protected DataTable DbGetJabatan()
        {
            try
            {
                this.sqlCon.Open();
                this.query = "SELECT * FROM TB_JABATAN";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDa = new SqlDataAdapter(this.sqlCmd);
                this.dt = new DataTable();
                this.sqlDa.Fill(this.dt);
                return this.dt;
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlDa.Dispose();
                this.query = null;
                this.dt.Dispose();
            }
        }

        protected int DbUpdateDataKaryawan(string kodeKaryawan, string nama, string jk, string noHp, string jabatan, byte[] foto)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "EXEC PROC_UPDATE_DATA_KARYAWAN @KODE_KARYAWAN, @NAMA, @JK, @NO_HP, @JABATAN, @FOTO";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@KODE_KARYAWAN", kodeKaryawan);
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
                this.sqlCmd.Dispose();
                this.query = null;
            }
        }

        protected int DbUpdataKodeKaryawan(string kodeKaryawan, string kodeKaryawanBaru)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"UPDATE TB_KARYAWAN SET KODE_KARYAWAN = @KODE_BARU WHERE KODE_KARYAWAN = '{kodeKaryawan}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@KODE_BARU", kodeKaryawanBaru);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlCmd.Dispose();
                this.query = null;
            }
        }

        protected int DbDeleteKaryawan(string kodeKaryawan)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"DELETE TB_KARYAWAN WHERE KODE_KARYAWAN = '{kodeKaryawan}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                return this.sqlCmd.ExecuteNonQuery();
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlCmd.Dispose();
                this.query = null;
            }
        }
    }
}

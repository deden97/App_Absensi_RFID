//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace App_Absensi_RFID.Model
{
    public class Model_Uc_AbsensiKaryawan
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDa;
        private SqlDataReader sqlDr;
        private DataTable dt;
        private string query;

        protected Model_Uc_AbsensiKaryawan() => this.sqlCon = Config.ConnectDb.GetConnection();

        protected DataTable DbGetDataAbsenHariIni(string tgl)
        {
            try
            {
                this.sqlCon.Open();
                // penulisan tgl => "thn/bln/tgl" => "2021/04/29"
                this.query = "SELECT TB_ABSENSI_KARYAWAN.KODE_ABSEN, " +
                             "TB_KARYAWAN.NAMA + ' (' + TB_ABSENSI_KARYAWAN.KARYAWAN + ')' AS[KARYAWAN], " +
                             "TB_ABSENSI_KARYAWAN.TANGGAL_ABSEN " +
                             "FROM TB_ABSENSI_KARYAWAN INNER JOIN TB_KARYAWAN " +
                             "ON TB_ABSENSI_KARYAWAN.KARYAWAN = TB_KARYAWAN.KODE_KARYAWAN " +
                             $"WHERE CONVERT(varchar, TB_ABSENSI_KARYAWAN.TANGGAL_ABSEN, 111) LIKE '%{tgl}%'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDa = new SqlDataAdapter(this.sqlCmd);
                this.dt = new DataTable();
                this.sqlDa.Fill(this.dt);
                return this.dt;
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlCmd.Dispose();
                this.query = null;
                this.dt.Dispose();
            }
        }

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
                this.sqlDr.Close();
            }
        }

        protected DataTable DbGetDataKaryawan(string kodeKaryawan)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT TB_KARYAWAN.KODE_KARYAWAN, TB_KARYAWAN.NAMA, " +
                             "TB_JABATAN.NAMA_JABATAN AS[JABATAN], TB_KARYAWAN.FOTO " +
                             "FROM TB_KARYAWAN INNER JOIN TB_JABATAN " +
                             "ON TB_KARYAWAN.JABATAN = TB_JABATAN.KODE_JABATAN " +
                             $"WHERE TB_KARYAWAN.KODE_KARYAWAN = '{kodeKaryawan}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDa = new SqlDataAdapter(this.sqlCmd);
                this.dt = new DataTable();
                this.sqlDa.Fill(this.dt);
                return this.dt;
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlCmd.Dispose();
                this.query = null;
                this.sqlDa.Dispose();
                this.dt.Dispose();
            }
        }

        protected bool DbSelectAbsensi(string kodeKaryawan, string tgl)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT KARYAWAN FROM TB_ABSENSI_KARYAWAN WHERE KARYAWAN = '{kodeKaryawan}' AND CONVERT(VARCHAR, TANGGAL_ABSEN, 111) LIKE '%{tgl}%'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDr = this.sqlCmd.ExecuteReader();
                return this.sqlDr.Read();
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlCmd.Dispose();
                this.query = null;
                this.sqlDr.Close();
            }
        }

        protected int DbSelectKodeAbsen(string kodeAbsen)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT KODE_ABSEN FROM TB_ABSENSI_KARYAWAN WHERE KODE_ABSEN LIKE '%{kodeAbsen}%'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDr = this.sqlCmd.ExecuteReader();
                int jmlRow = 0;
                while (this.sqlDr.Read())
                    jmlRow++;
                return jmlRow;
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlCmd.Dispose();
                this.query = null;
            }
        }

        protected int DbInsertAbsen(string kodeAbsen, string kodeKaryawan, string tgl)
        {
            try
            {
                this.sqlCon.Open();
                this.query = "INSERT INTO TB_ABSENSI_KARYAWAN VALUES(@KODE_ABSEN, @KODE_KARYAWAN, @TGL)";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlCmd.Parameters.AddWithValue("@KODE_ABSEN", kodeAbsen);
                this.sqlCmd.Parameters.AddWithValue("@KODE_KARYAWAN", kodeKaryawan);
                this.sqlCmd.Parameters.AddWithValue("@TGL", tgl);
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

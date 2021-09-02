//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace App_Absensi_RFID.Model
{
    public class Model_Uc_LaporanAbsen
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlDr;
        private SqlDataAdapter sqlDa;
        private DataTable dt;
        private string query;

        protected Model_Uc_LaporanAbsen() => this.sqlCon = Config.ConnectDb.GetConnection();

        protected DataTable DbDataLaporanAbsen(string tgl)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"EXEC PROC_LAPORAN_ABSEN '{tgl}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDa = new SqlDataAdapter(this.sqlCmd);
                this.dt = new DataTable();
                this.sqlDa.Fill(this.dt);
                return this.dt;
            }
            finally
            {
                this.sqlCon.Close();
                this.query = null;
                this.sqlCmd.Dispose();
                this.sqlDa.Dispose();
            }
        }

        protected string DbSelectNamaAdmin(object kodeAdmin)
        {
            try
            {
                this.sqlCon.Open();
                this.query = $"SELECT NAMA FROM TB_ADMIN WHERE KODE_ADMIN = '{kodeAdmin}'";
                this.sqlCmd = new SqlCommand(this.query, this.sqlCon);
                this.sqlDr = this.sqlCmd.ExecuteReader();
                this.sqlDr.Read();
                return this.sqlDr.GetString(0);
            }
            finally
            {
                this.sqlCon.Close();
                this.sqlCmd.Dispose();
                this.query = null;
                this.sqlDr.Close();
            }
        }
    }
}
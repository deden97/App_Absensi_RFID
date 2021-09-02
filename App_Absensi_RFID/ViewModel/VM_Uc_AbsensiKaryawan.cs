using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data;

namespace App_Absensi_RFID.ViewModel
{
    public sealed class VM_Uc_AbsensiKaryawan : Model.Model_Uc_AbsensiKaryawan
    {
        private string kodeKaryawan, nama, jabatan;
        private byte[] foto;
        public string KodeKaryawan { get { return this.kodeKaryawan; } }
        public string Nama { get { return this.nama; } }
        public string Jabatan { get { return this.jabatan; } }
        public byte[] Foto { get { return this.foto; } }

        public DataTable GetDataAbsen(string tgl) => base.DbGetDataAbsenHariIni(tgl);

        public bool CekKodeIn(string kodeIn)
        {
            bool output = false;
            if (base.DbSelectKodeKaryawan(kodeIn))
            {
                DataTable dt = base.DbGetDataKaryawan(kodeIn);
                foreach(DataRow dtRow in dt.Rows)
                {
                    this.kodeKaryawan = dtRow["KODE_KARYAWAN"].ToString();
                    this.nama = dtRow["NAMA"].ToString();
                    this.jabatan = dtRow["JABATAN"].ToString();
                    this.foto = (byte[])dtRow["FOTO"];
                }
                output = true;
            }

            return output;
        }

        public bool CekAbsensiHariIni(string kodeKaryawan, string tgl) => base.DbSelectAbsensi(kodeKaryawan, tgl);

        public int GetUrutanAbsen(string kodeAbsen) => base.DbSelectKodeAbsen(kodeAbsen) + 1;

        public string SimpanAbsen(string kodeKaryawan)
        {
            //simpan absensi ke tb_absensi_karyawan
            string thn = DateTime.Now.ToString("yy");
            string bln = DateTime.Now.ToString("MM");
            string hr = DateTime.Now.ToString("dd");
            string kodeAbsen = $"{thn}{bln}{hr}ABS";
            string kodeAbsenHariIni = kodeAbsen + Convert.ToString(base.DbSelectKodeAbsen(kodeAbsen) + 1);
            string tglAbsen = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            int simpan = base.DbInsertAbsen(kodeAbsenHariIni, kodeKaryawan, tglAbsen);
            return (simpan == 1) ? "Absen Tercatat." : "Absen gagal.";
        }
    }
}

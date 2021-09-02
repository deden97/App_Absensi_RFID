//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data;

namespace App_Absensi_RFID.ViewModel
{
    public sealed class VM_Uc_EditDataKaryawan : Model.Model_Uc_EditDataKaryawan
    {
        private string terdaftar, nama, jk, noHp, jabatan;
        byte[] foto;
        public string Terdaftar { get { return this.terdaftar; } }
        public string Nama { get { return this.nama; } }
        public string JK { get { return this.jk; } }
        public string NoHp { get { return this.noHp; } }
        public string Jabatan { get { return this.jabatan; } }
        public byte[] Foto { get { return this.foto; } }

        public DataTable GetJabatan() => base.DbGetJabatan();

        public bool CekKodeInDb(string kodeIn) => base.DbSelectKodeKaryawan(kodeIn);

        public string CekKodeInBaru(string kodeIn, string txt) => (kodeIn.Length >= 8) ? kodeIn : txt;

        public object[] CekKodeKaryawan(string kodeKaryawan)
        {
            string txtErr = "";
            bool enable = false;
            bool cekKode = base.DbSelectKodeKaryawan(kodeKaryawan);
            if (cekKode)
            {
                DataTable dt = base.DbGetDataKaryawan(kodeKaryawan);
                foreach (DataRow dtRow in dt.Rows)
                {
                    this.terdaftar = dtRow["TERDAFTAR"].ToString();
                    this.nama = dtRow["NAMA"].ToString();
                    this.jk = dtRow["JENIS_KELAMIN"].ToString();
                    this.noHp = dtRow["NO_HP"].ToString();
                    this.jabatan = dtRow["JABATAN"].ToString();
                    this.foto = (byte[])dtRow["FOTO"];
                }
                enable = true;
            }
            else
                txtErr = "Kode tidak terdaftar.";

            return new object[] { txtErr, enable };
        }

        public object[] CekNama(string nama)
        {
            string txtErr = "";
            bool enable = false;
            if (nama.Length > 30)
                txtErr = "Nama maksimal 30 karakter, nama bisa di singkat.";
            else if (nama.Length <= 30 && nama.Length > 0)
                enable = true;

            return new object[] { txtErr, enable };
        }

        public object[] CekJenisKelamin(char jk) => (jk == 'L' || jk == 'P') ? new object[] { jk, true } : new object[] { "", false };

        public object[] CekNoHp(string noHp)
        {
            string txtErr = "";
            bool enable = false;
            if (noHp.Length > 15)
                txtErr = "Maksimal 15 karakter.";
            else if (noHp.Length <= 15 && noHp.Length > 7)
                enable = true;

            return new object[] { txtErr, enable };
        }

        public string EditDataKaryawan(string kodeKaryawan, string nama, string jk, string noHp, string jabatan, byte[] foto)
        {
            int update = base.DbUpdateDataKaryawan(kodeKaryawan, nama, jk, noHp, jabatan, foto);
            return (update == 1) ? "Edit data berhasil." : "Edit data gagal.";
        }

        public string HapusKaryawan(string kodeKaryawan)
        {
            int hapus = base.DbDeleteKaryawan(kodeKaryawan);
            return (hapus == 1) ? "Data Karyawan berhasil dihapus." : "Data Karyawan gagal dihapus.";
        }

        public string CekKodeSaatIni(string kodeSaatIni) => (kodeSaatIni.Length >= 8) ? "Scan kartu / tag baru yang belum digunakan" : null;

        public string GantiKartu(string kodeKaryawan, string kodeKaryawanBaru)
        {
            int ganti = base.DbUpdataKodeKaryawan(kodeKaryawan, kodeKaryawanBaru);
            return (ganti == 1) ? "Kartu / tag / kode Karyawan berhasil di ganti" : "Kartu / tag / kode Karyawan gagal di ganti";
        }
    }
}

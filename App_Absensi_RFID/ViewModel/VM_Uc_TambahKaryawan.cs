//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.ViewModel
{
    public sealed class VM_Uc_TambahKaryawan : Model.Model_Uc_TambahKaryawan
    {
        public System.Data.DataTable GetJabatan() => base.DbGetJabatan();

        public string CekKodeIn(string kodeIn, string txt) => (kodeIn.Length >= 8) ? kodeIn : txt;

        public object[] CekKodeKaryawan(string kodeKaryawan)
        {
            string txtErr = "";
            bool enable = false;
            if(kodeKaryawan.Length >= 8)
            {
                if (base.DbGetKodeKaryawan(kodeKaryawan))
                    txtErr = "Kode sudah digunakan.";
                else
                    enable = true;
            }

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

        public string InsertKaryawan(object kodeKaryawan, string terdaftar, string nama, string jk, string noHp, string jabatan, byte[] foto)
        {
            string txtMsg = "";
            int insert = base.DbinsertKaryawan(kodeKaryawan, terdaftar, nama, jk, noHp, jabatan, foto);
            if (insert == 1)
                txtMsg = "Data berhasil disimpan.";
            else
                txtMsg = "Data gagal disimpan.";

            return txtMsg;
        }
    }
}

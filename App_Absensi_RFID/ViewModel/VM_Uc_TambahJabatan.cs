//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.ViewModel
{
    public sealed class VM_Uc_TambahJabatan : Model.Model_Uc_TambahJabatan
    {
        public object[] CekKodejabatan(string kodeJabatan)
        {
            int kjLength = kodeJabatan.Length;
            bool cekKode = base.DbCekKodeJabatan(kodeJabatan);
            string txtErr = "";
            bool enable = false;

            txtErr = (kjLength > 3) ? "Kode jabatan maksimal 3 karakter." : txtErr;
            txtErr = cekKode ? "Kode jabatan sudah digunakan, buat kode jabatan yang berbeda." : txtErr;
            enable = ((kjLength <= 3 && kjLength > 0) && !cekKode) ? true : false;

            return new object[] { txtErr, enable };
        }

        public object[] CekNamaJabatan(string namaJabatan)
        {
            int njLength = namaJabatan.Length;
            bool cekNama = base.DbCekNamaJabatan(namaJabatan);
            string txtErr = "";
            bool enable = true;

            txtErr = (njLength > 30) ? "Nama jabatan maksimal 30 karakter." : txtErr;
            txtErr = cekNama ? "Nama jabatan sudah ada." : txtErr;
            enable = ((njLength <= 30 && njLength > 0) && !cekNama) ? true : false;

            return new object[] { txtErr, enable };
        }

        public string TambahJabatan(string kodeJabatan, string namaJabatan)
        {
            int tambah = base.DbInsertJabatan(kodeJabatan, namaJabatan);
            return (tambah == 1) ? "Jabatan berhasil disimpan." : "Jabatan gagal disimpan.";
        }

        public System.Data.DataTable GetTbJabatan() => base.DbGetTbJabatan();
    }
}

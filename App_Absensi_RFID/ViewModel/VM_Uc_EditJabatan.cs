//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.ViewModel
{
    public class VM_Uc_EditJabatan : Model.Model_EditJabatan
    {
        public System.Data.DataTable GetTbJabatan() => base.DbGetTbJabatan();

        public object[] CekNamaJabatan(string jabatanTerpilih, string namaJabatanBaru)
        {
            string txtErr = "";
            bool enableEdit = false;
            bool enableHapus = true;
            if(jabatanTerpilih != namaJabatanBaru)
            {
                int namalength = namaJabatanBaru.Length;
                if (namalength > 0 && namalength > 30)
                    txtErr = "Nama jabatan maksimal 30 karakter.";
                else if (namalength > 0 && namalength <= 30)
                {
                    if (base.DbCekNamaJabatan(namaJabatanBaru))
                        txtErr = "Nama jabatan sudah ada.";
                    else
                        enableEdit = true;
                }
                else
                    enableHapus = false;
            }

            return new object[] { txtErr, enableEdit, enableHapus };
        }

        public string EditJabatan(object kodeJabatan, string namaJabatan)
        {
            int edit = base.DbEditJabatan(kodeJabatan, namaJabatan);
            return (edit == 1) ? "Jabatan berhasil di edit." : "Jabatan gagal diedit.";
        }

        public string DeleteJabatan(object kodeJabatan)
        {
            int hapus = base.DbDeleteJabatan(kodeJabatan);
            return (hapus == 1) ? "Jabatan berhasil dihapus." : "Jabatan gagal dihapus.";
        }
    }
}

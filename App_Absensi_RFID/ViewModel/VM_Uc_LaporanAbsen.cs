//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data;

namespace App_Absensi_RFID.ViewModel
{
    public sealed class VM_Uc_LaporanAbsen : Model.Model_Uc_LaporanAbsen
    {
        public DataTable GetDataLaporan(string tgl) => base.DbDataLaporanAbsen(tgl);

        public string GetNamaAdmin(object kodeAdmin) => base.DbSelectNamaAdmin(kodeAdmin);
    }
}

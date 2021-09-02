//using System;
//using System.Collections.Generic;
using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.ViewModel
{
    public sealed class VM_FrmLogin : Model.Model_FrmLogin
    {
        public object KodeAdmin { get; set; }
        public object NamaAdmin { get; set; }
        public byte[] Foto { get; set; }

        public bool ValidasiLogin(string username, string password)
        {
            bool login = base.Login(username, password);
            if(login)
            {
                DataTable dt = base.GetDataAdmin(username, password);
                foreach (DataRow dtRow in dt.Rows)
                {
                    this.KodeAdmin = dtRow["KODE_ADMIN"];
                    this.NamaAdmin = dtRow["NAMA"];
                    this.Foto = (byte[])dtRow["FOTO"];
                }
            }

            return login;
        }
    }
}

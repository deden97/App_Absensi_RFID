//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.ViewModel
{
    public sealed class VM_Uc_TambahAkunAdmin : Model.Model_Uc_TambahAkunAdmin
    {
        private string txtErr;

        public object[] CekNama(string nama)
        {
            this.txtErr = "";
            bool enable = false;
            if (nama.Length > 30)
                this.txtErr = "Nama maksimal 30 karakter, nama bisa di singkat.";
            else if (nama.Length <= 30 && nama.Length > 0)
                enable = true;

            return new object[] { this.txtErr, enable };
        }

        public bool CekJK(char jk) => (jk == 'L' || jk == 'P') ? true : false;

        public object[] CekNoHp(string noHp)
        {
            this.txtErr = "";
            bool enable = false;
            if (noHp.Length > 15)
                this.txtErr = "Maksimal 15 karakter.";
            else if(noHp.Length <= 15 && noHp.Length > 7)
                enable = true;

            return new object[] { this.txtErr, enable };
        }

        public object[] CekUsername(string username)
        {
            this.txtErr = "";
            bool enable = false;
            if(username.Length > 15)
                this.txtErr = "Username maksimal 15 karakter.";
            else
            {
                if (base.SelectUsername(username))
                    this.txtErr = "Username sudah digunakan, buat username yang berbeda.";
                else if(!base.SelectUsername(username) && username.Length > 0)
                    enable = true;
            }

            return new object[] { this.txtErr, enable };
        }

        public object[] CekPassword(string password)
        {
            this.txtErr = "";
            bool enable = false;
            if(password.Length > 255)
                this.txtErr = "Password maksimal 255 karakter.";
            else if(password.Length <= 255 && password.Length > 0)
                enable = true;

            return new object[] { this.txtErr, enable };
        }

        public object[] CekKonfirPassword(string konfirPassword, string password)
        {
            this.txtErr = "";
            bool enable = false;
            if (konfirPassword != password)
                this.txtErr = "Password tidak sesuai.";
            else
                enable = true;

            return new object[] { this.txtErr, enable };
        }

        public int jmlAdmin() => base.JumlahAdmin() + 1;

        public bool Submit(object kodeAdmin, object nama, object jk, object noHp, object username, object password, byte[] foto)
        {
            int insertAdmin = base.InsertAdmin(kodeAdmin, nama, jk, noHp, foto);
            int insertAkun = base.InsertAkunAdmin(kodeAdmin, username, password);
            return (insertAdmin == insertAkun);
        }
    }
}
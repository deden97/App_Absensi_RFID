//using System;
//using System.Collections.Generic;
using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace App_Absensi_RFID.ViewModel
{
    public sealed class VM_Uc_EditDataAdmin : Model.Model_Uc_EditDataAdmin
    {
        private string kodeAdmin, txtErr;
        public string KodeAdmin { get { return this.kodeAdmin; } }

        /* form1 ***************/
        private string nama, jenisKelamin, noHp;
        private byte[] foto;
        public string Nama { get { return this.nama; } }
        public string JenisKelamin { get { return this.jenisKelamin; } }
        public string NoHp { get { return this.noHp; } }
        public byte[] Foto { get { return this.foto; } }

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
            else if (noHp.Length <= 15 && noHp.Length > 7)
                enable = true;

            return new object[] { this.txtErr, enable };
        }

        public bool CekDataAdmin1(object kodeAdmin)
        {
            bool output = true;
            DataTable dt = base.GetDataAdmin(kodeAdmin);
            if (dt.Rows.Count == 1)
            {
                foreach(DataRow dtRow in dt.Rows)
                {
                    this.kodeAdmin = dtRow[0].ToString();
                    this.nama = dtRow[1].ToString();
                    this.jenisKelamin = dtRow[2].ToString();
                    this.noHp = dtRow[3].ToString();
                    this.foto = (byte[])dtRow[4];
                }
            }
            else
                output = false;

            return output;
        }

        public string UpdateData1(object kodeAdmin, object nama, object jenisKelamin, object noHp, byte[] foto)
        {
            int update = base.UpdataDataAdmin(kodeAdmin, nama, jenisKelamin, noHp, foto);
            return (update == 1) ? "Data berhasil di update." : "Update data gagal.";
        }
        /*************** form1 */

        /* form2 ***************/
        public object[] GetUsername2(object kodeAdmin) => base.GetUsername(kodeAdmin);

        public object[] CekUsernameBaru2(string usernameSaatIni, string usernameBaru)
        {
            this.txtErr = "";
            bool enable = false;
            if (usernameBaru.Length > 15)
                this.txtErr = "Username maksimal 15 karakter.";
            else
            {
                if(usernameBaru != usernameSaatIni)
                {
                    if (base.CekUsernameBaru(usernameBaru))
                        this.txtErr = "Username sudah digunakan, buat username yang berbeda.";
                    else if (!base.CekUsernameBaru(usernameBaru) && usernameBaru.Length > 0)
                        enable = true;
                }
            }

            return new object[] { this.txtErr, enable };
        }

        public string UpdateData2(object kodeAdmin, object usernameBaru)
        {
            int update = base.UpdateUsername(kodeAdmin, usernameBaru);
            return (update == 1) ? "Data berhasil di update." : "Update data gagal.";
        }

        /*************** form2 */

        /*************** form3 */
        public object[] CekPassword(string password)
        {
            this.txtErr = "";
            bool enable = false;
            if (password.Length > 255)
                this.txtErr = "Password maksimal 255 karakter.";
            else if (password.Length <= 255 && password.Length > 0)
                enable = true;

            return new object[] { this.txtErr, enable };
        }

        public object[] CekPasswordSaatIni(object kodeAdmin, object passwordBaru, object passwordSaatIni)
        {
            this.txtErr = "";
            bool enable = base.GetPassword(kodeAdmin, passwordSaatIni);
            if (!string.IsNullOrEmpty(passwordSaatIni.ToString()))
            {
                if (!enable)
                    this.txtErr = "Password tidak sesuai";

                if (passwordBaru.ToString() == passwordSaatIni.ToString())
                {
                    this.txtErr = "Password sama, jadi tidak perlu di edit";
                    enable = false;
                }
            }

            return new object[] { this.txtErr, enable };
        }

        public string UpdateData3(object kodeAdmin, object passwordBaru, object passwordSaatIni)
        {
            int edit = base.UpdatePassword(kodeAdmin, passwordBaru, passwordSaatIni);
            return (edit == 1) ? "Edit password berhasil." : "Edit password gagal.";
        }
        /*************** form3 */
    }
}
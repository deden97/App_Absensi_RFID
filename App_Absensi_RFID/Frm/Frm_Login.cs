using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Absensi_RFID.Frm
{
    public partial class Frm_Login : Form
    {
        private ViewModel.VM_FrmLogin vmLogin = new ViewModel.VM_FrmLogin();
        public bool Login { get; set; }
        public bool BatalLogin { get; set; }
        public object KodeAdmin { get; set; }
        public object NamaAdmin { get; set; }
        public byte[] Foto { get; set; }
        private string txtMsg;

        public Frm_Login()
        {
            InitializeComponent();
            this.Login = false; // kondisi login
            this.BatalLogin = false; // kondisi logout
            this.Load += delegate { this.txtUsername.Focus(); }; // form load
            this.btnLogin.Click += delegate { this.Log(); }; // button login
            this.btnBatal.Click += delegate { this.BatalLogin = true; }; // button batal
            this.cbTampilkanPassword.CheckedChanged += delegate { this.txtPassword.UseSystemPasswordChar = !this.cbTampilkanPassword.Checked; }; // checkbox tampilkan password
        }

        private void Log()
        {
            this.Login = this.vmLogin.ValidasiLogin(this.txtUsername.Text, this.txtPassword.Text);
            if (this.Login)
            {
                this.KodeAdmin = this.vmLogin.KodeAdmin;
                this.NamaAdmin = this.vmLogin.NamaAdmin;
                this.Foto = this.vmLogin.Foto;
            }
            else
            {
                this.txtMsg = "Username atau password salah! \nMohon periksa kembali.";
                MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.Log();
        }
    }
}

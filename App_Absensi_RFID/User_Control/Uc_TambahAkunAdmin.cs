using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Absensi_RFID.User_Control
{
    public partial class Uc_TambahAkunAdmin : UserControl, Config.IUserControl
    {
        private static Uc_TambahAkunAdmin instance;
        public static Uc_TambahAkunAdmin Instance { get { return (instance == null) ? instance = new Uc_TambahAkunAdmin() : instance; } }
        private ViewModel.VM_Uc_TambahAkunAdmin vmTambahAkun = new ViewModel.VM_Uc_TambahAkunAdmin();
        private object kodeAdmin;
        private string txtErr, txtMsg, jenisKelamin;

        public Uc_TambahAkunAdmin()
        {
            InitializeComponent();
            this.txtNamaLengkap.Focus();
            this.rbLaki2.CheckedChanged += delegate { this.SetJK('L'); };
            this.rbPerempuan.CheckedChanged += delegate { this.SetJK('P'); };
            this.ckbTampilkanPassword.CheckedChanged += delegate
            {
                this.txtPassword.UseSystemPasswordChar = !this.ckbTampilkanPassword.Checked;
                this.txtKonfirPassword.UseSystemPasswordChar = !this.ckbTampilkanPassword.Checked;
            };
            this.btnBatal.Click += delegate { this.ClearForm(); };
        }

        public void ResetForm(object kodeAdmin)
        {
            this.kodeAdmin = kodeAdmin;
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.txtNamaLengkap.Clear();
            this.txtNamaLengkap.Focus();
            this.rbLaki2.Checked = false;
            this.rbPerempuan.Checked = false;
            this.SetJK('*');
            this.txtNoHp.Clear();
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.txtKonfirPassword.Clear();
            this.ckbTampilkanPassword.Checked = false;
            this.pictureBox1.Image = Properties.Resources.profile_user;
            this.btnPilihFoto.Enabled = false;
            this.btnSubmit.Enabled = false;
        }

        private void txtNamaLengkap_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmTambahAkun.CekNama(this.txtNamaLengkap.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtNamaLengkap, this.txtErr);
            this.rbLaki2.Enabled = Convert.ToBoolean(result[1]);
            this.rbPerempuan.Enabled = Convert.ToBoolean(result[1]);
        }

        private void SetJK(char jk)
        {
            this.jenisKelamin = (this.rbLaki2.Checked || this.rbPerempuan.Checked) ? jk.ToString() : "";
            this.txtNoHp.Enabled = this.vmTambahAkun.CekJK(jk);
        }

        private void txtNoHp_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmTambahAkun.CekNoHp(this.txtNoHp.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtNoHp, this.txtErr);
            this.txtUsername.Enabled = Convert.ToBoolean(result[1]);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmTambahAkun.CekUsername(this.txtUsername.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtUsername, this.txtErr);
            this.txtPassword.Enabled = Convert.ToBoolean(result[1]);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmTambahAkun.CekPassword(this.txtPassword.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtPassword, this.txtErr);
            this.txtKonfirPassword.Enabled = Convert.ToBoolean(result[1]);
        }

        private void txtKonfirPassword_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmTambahAkun.CekKonfirPassword(this.txtKonfirPassword.Text, this.txtPassword.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtKonfirPassword, this.txtErr);
            this.btnPilihFoto.Enabled = Convert.ToBoolean(result[1]);
            this.btnSubmit.Enabled = Convert.ToBoolean(result[1]);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Submit data akun?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    string kodeAdm = DateTime.Now.ToString("yyMMdd") + "ADM" + this.vmTambahAkun.jmlAdmin().ToString();
                    byte[] foto;
                    System.IO.MemoryStream mStream = new System.IO.MemoryStream();
                    this.pictureBox1.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Png);
                    foto = mStream.GetBuffer();
                    bool submit = this.vmTambahAkun.Submit(kodeAdm, this.txtNamaLengkap.Text, this.jenisKelamin, this.txtNoHp.Text, this.txtUsername.Text, this.txtKonfirPassword.Text, foto);
                    if (submit)
                    {
                        this.txtMsg = "Akun berhasil dibuat";
                        MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearForm();
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                }
            }
        }

        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            this.ofd.Filter = "Image File(*.jpg; *.png) | *.jpg; *.png";
            if(this.ofd.ShowDialog() == DialogResult.OK)
                this.pictureBox1.Image = Image.FromStream(this.ofd.OpenFile());
        }
    }
}
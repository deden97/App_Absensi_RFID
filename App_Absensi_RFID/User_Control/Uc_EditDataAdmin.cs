using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App_Absensi_RFID.User_Control
{
    public partial class Uc_EditDataAdmin : UserControl, Config.IUserControl
    {
        public static Uc_EditDataAdmin instance;
        public static Uc_EditDataAdmin Instance { get { return (instance == null) ? instance = new Uc_EditDataAdmin() : instance; } }
        private ViewModel.VM_Uc_EditDataAdmin vmEdit = new ViewModel.VM_Uc_EditDataAdmin();
        private object kodeAdmin;
        private byte[] foto;
        private string txtErr, txtMsg, jenisKelamin;
        public bool UpdateData { get; set; }
        public string GetKodeAdmin { get { return this.kodeAdmin.ToString(); } }
        public string GetNama { get { return this.txtNamaLengkap1.Text; } }
        public byte[] GetFoto { get { return this.foto; } }

        public Uc_EditDataAdmin()
        {
            InitializeComponent();

            this.tabControl1.Selected += delegate { this.TabControlSelect(); };

            /* form1 ***************/
            this.rbLaki21.CheckedChanged += delegate { this.SetJK('L'); };
            this.rbPerempuan1.CheckedChanged += delegate { this.SetJK('P'); };
            /*************** form1 */

            /* form3 ***************/
            this.ckbTampilkanPassword3.CheckedChanged += delegate
            {
                this.txtPasswordBaru3.UseSystemPasswordChar = !this.ckbTampilkanPassword3.Checked;
                this.txtPasswordSaatIni3.UseSystemPasswordChar = !this.ckbTampilkanPassword3.Checked;
            };
            /*************** form3 */
        }

        public void ResetForm(object kodeAdmin)
        {
            this.kodeAdmin = kodeAdmin;
            this.tabControl1.SelectedTab = this.tabPage1;
            this.TabControlSelect();
        }

        private void TabControlSelect()
        {
            if (this.tabControl1.SelectedTab == this.tabPage1)
                this.FillForm1(this.kodeAdmin);
            else if (this.tabControl1.SelectedTab == this.tabPage2)
                this.FillForm2(this.kodeAdmin);
            else
                this.FillForm3(this.kodeAdmin);
        }

        /* form1 ***************/
        private void FillForm1(object kodeAdmin)
        {
            if(this.vmEdit.CekDataAdmin1(kodeAdmin))
            {
                this.txtKodeAdmin1.Text = this.vmEdit.KodeAdmin;
                this.txtNamaLengkap1.Text = this.vmEdit.Nama;
                this.jenisKelamin = this.vmEdit.JenisKelamin;
                if (this.jenisKelamin == "L")
                {
                    this.rbLaki21.Checked = true;
                    this.SetJK('L');
                }
                else
                {
                    this.rbPerempuan1.Checked = true;
                    this.SetJK('P');
                } 
                this.txtNoHp1.Text = this.vmEdit.NoHp;
                try
                {
                    MemoryStream mStream = new MemoryStream(this.vmEdit.Foto);
                    this.pictureBox1.Image = Image.FromStream(mStream);
                }
                catch (Exception err) { err.ToString(); }
            }
        }

        private void ClearForm1()
        {
            this.txtNamaLengkap1.Clear();
            this.txtNamaLengkap1.Focus();
            this.rbLaki21.Checked = false;
            this.rbPerempuan1.Checked = false;
            this.SetJK('*');
            this.txtNoHp1.Clear();
            this.pictureBox1.Image = Properties.Resources.profile_user;
            this.btnPilihFoto1.Enabled = false;
            this.btnEditData1.Enabled = false;
        }

        private void txtNamaLengkap1_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmEdit.CekNama(this.txtNamaLengkap1.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtNamaLengkap1, this.txtErr);
            this.rbLaki21.Enabled = Convert.ToBoolean(result[1]);
            this.rbPerempuan1.Enabled = Convert.ToBoolean(result[1]);
        }

        private void SetJK(char jk)
        {
            this.jenisKelamin = (jk == 'L' || jk == 'P') ? jk.ToString() : null;
            this.txtNoHp1.Enabled = this.vmEdit.CekJK(jk);
        }

        private void txtNoHp1_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmEdit.CekNoHp(this.txtNoHp1.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtNoHp1, this.txtErr);
            this.btnPilihFoto1.Enabled = Convert.ToBoolean(result[1]);
            this.btnEditData1.Enabled = Convert.ToBoolean(result[1]);
        }

        private void btnPilihFoto1_Click(object sender, EventArgs e)
        {
            this.ofd.Filter = "Image File(*.jpg; *.png) | *.jpg; *.png";
            if (this.ofd.ShowDialog() == DialogResult.OK)
                this.pictureBox1.Image = Image.FromStream(this.ofd.OpenFile());
        }

        private void btnEditData1_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Edit informasi data?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    MemoryStream mStream = new MemoryStream();
                    this.pictureBox1.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Png);
                    this.foto = mStream.GetBuffer();
                    this.txtMsg = this.vmEdit.UpdateData1(this.kodeAdmin, this.txtNamaLengkap1.Text, this.jenisKelamin, this.txtNoHp1.Text, this.foto);
                    MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.UpdateData = true;
                }
                catch (Exception err) { MessageBox.Show(err.ToString()); }
            }
        }

        private void btnClearForm1_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Bersihkan form?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.ClearForm1();
        }

        private void btnBatal1_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Kembalikan ke data semula?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.FillForm1(this.kodeAdmin);
        }
        /*************** form1 */

        /* form2 ***************/
        private void FillForm2(object kodeAdmin)
        {
            object[] dt = this.vmEdit.GetUsername2(this.kodeAdmin);
            this.txtKodeAdmin2.Text = dt[0].ToString();
            this.txtUsernameSaatini2.Text = dt[1].ToString();
            this.txtUsernameBaru2.Clear();
            this.txtUsernameBaru2.Focus();
        }

        private void txtUsernameBaru2_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmEdit.CekUsernameBaru2(this.txtUsernameSaatini2.Text, this.txtUsernameBaru2.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtUsernameBaru2, this.txtErr);
            this.btnEditData2.Enabled = Convert.ToBoolean(result[1]);
        }

        private void btnUpdateData2_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Edit username?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                this.txtMsg = this.vmEdit.UpdateData2(this.kodeAdmin, this.txtUsernameBaru2.Text);
                MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUsernameBaru2.Clear();
                this.txtUsernameBaru2.Focus();
            }
        }

        private void btnBatal2_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Batalkan?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.txtUsernameBaru2.Clear();
                this.txtUsernameBaru2.Focus();
            }
        }

        /*************** form2 */

        /* form3 ***************/
        private void FillForm3(object kodeAdmin)
        {
            this.txtKodeAdmin3.Text = kodeAdmin.ToString();
            this.txtPasswordBaru3.Clear();
        }

        private void txtPasswordBaru3_TextChanged(object sender, EventArgs e)
        {
            this.txtPasswordSaatIni3.Clear();
            object[] result = this.vmEdit.CekPassword(this.txtPasswordBaru3.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtPasswordBaru3, this.txtErr);
            this.txtPasswordSaatIni3.Enabled = Convert.ToBoolean(result[1]);
        }

        private void txtPasswordSaatIni3_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmEdit.CekPasswordSaatIni(this.kodeAdmin, this.txtPasswordBaru3.Text, this.txtPasswordSaatIni3.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtPasswordSaatIni3, this.txtErr);
            this.btnEditData3.Enabled = Convert.ToBoolean(result[1]);
        }

        private void btnEditData3_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Edit Password?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                this.txtMsg = this.vmEdit.UpdateData3(this.kodeAdmin, this.txtPasswordBaru3.Text, this.txtPasswordSaatIni3.Text);
                MessageBoxIcon icon = (!this.txtMsg.ToLower().Contains("gagal")) ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
                MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, icon);
            }
        }

        private void btnBatal3_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Batalkan?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.txtPasswordBaru3.Clear();
        }
        /*************** form3 */
    }
}
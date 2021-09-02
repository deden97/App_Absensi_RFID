using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Absensi_RFID.User_Control
{
    public partial class Uc_TambahJabatan : UserControl, Config.IUserControl
    {
        private static Uc_TambahJabatan instance;
        public static Uc_TambahJabatan Instance { get { return (instance == null) ? instance = new Uc_TambahJabatan() : instance; } }
        private ViewModel.VM_Uc_TambahJabatan vmJabatan = new ViewModel.VM_Uc_TambahJabatan();
        private object kodeAdmin;
        private string txtErr, txtMsg;

        public Uc_TambahJabatan() => InitializeComponent();

        public void ResetForm(object kodeAdmin)
        {
            this.kodeAdmin = kodeAdmin;
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.UpdateDgv();
            this.txtKodeJabatan.Clear();
            this.txtNamaJabatan.Clear();
            this.txtKodeJabatan.Focus();
        }

        private void UpdateDgv()
        {
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.DataSource = this.vmJabatan.GetTbJabatan();
            int jmlRow = this.dgv.RowCount;
            for (int i = 1; i < jmlRow; i++)
                this.dgv.Rows[i - 1].Cells["dgvNo"].Value = i;
            this.txtTotJabatan.Text = Convert.ToString(jmlRow - 1);
        }

        private void txtKodeJabatan_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmJabatan.CekKodejabatan(this.txtKodeJabatan.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtKodeJabatan, this.txtErr);
            this.txtNamaJabatan.Enabled = Convert.ToBoolean(result[1]);
        }

        private void txtNamaJabatan_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmJabatan.CekNamaJabatan(this.txtNamaJabatan.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtNamaJabatan, this.txtErr);
            this.btnTambahJabatan.Enabled = Convert.ToBoolean(result[1]);
        }

        private void btnTambahJabatan_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Tambah jabatan?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                this.txtMsg = this.vmJabatan.TambahJabatan(this.txtKodeJabatan.Text, this.txtNamaJabatan.Text);
                MessageBoxIcon icon = this.txtMsg.ToLower().Contains("gagal") ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
                MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, icon);
                this.UpdateDgv();
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Bersihkan Form?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.ClearForm();
        }
    }
}
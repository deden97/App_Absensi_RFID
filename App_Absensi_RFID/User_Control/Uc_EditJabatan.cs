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
    public partial class Uc_EditJabatan : UserControl, Config.IUserControl
    {
        private static Uc_EditJabatan instance;
        public static Uc_EditJabatan Instance { get { return (instance == null) ? instance = new Uc_EditJabatan() : instance; } }
        private ViewModel.VM_Uc_EditJabatan vmEdit = new ViewModel.VM_Uc_EditJabatan();
        private object kodeAdmin, kodeJabatanTerpilih;
        private string jabatanTerpilih;

        public Uc_EditJabatan()
        {
            InitializeComponent();
        }

        public void ResetForm(object kodeAdmin)
        {
            this.kodeAdmin = kodeAdmin;
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.kodeJabatanTerpilih = null;
            this.UpdateDgv();
            this.txtKodeJabatan.Clear();
            this.txtNamaJabatan.Clear();
            this.txtNamaJabatan.Enabled = false;
        }

        private void UpdateNoDgv()
        {
            int jmlRow = this.dgv.RowCount;
            for (int i = 1; i < jmlRow; i++)
                this.dgv.Rows[i - 1].Cells["dgvNo"].Value = i;
            this.txtTotJabatan.Text = Convert.ToString(jmlRow - 1);
        }

        private void UpdateDgv()
        {
            this.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.DataSource = this.vmEdit.GetTbJabatan();
            this.UpdateNoDgv();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.kodeJabatanTerpilih = dgv.Rows[e.RowIndex].Cells["dgvKodeJabatan"].Value.ToString();
                this.txtKodeJabatan.Text = this.kodeJabatanTerpilih.ToString();
                this.jabatanTerpilih = dgv.Rows[e.RowIndex].Cells["dgvNamaJabatan"].Value.ToString();
                this.txtNamaJabatan.Text = this.jabatanTerpilih;
                this.txtNamaJabatan.Enabled = true;
                this.txtNamaJabatan.Focus();
            }
        }

        private void txtNamaJabatan_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmEdit.CekNamaJabatan(this.jabatanTerpilih.ToLower(), this.txtNamaJabatan.Text.ToLower());
            this.errorProvider1.SetError(this.txtNamaJabatan, result[0].ToString());
            this.btnEdit.Enabled = Convert.ToBoolean(result[1]);
            this.btnHapus.Enabled = Convert.ToBoolean(result[2]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string txtMsg = "Edit jabatan?";
            DialogResult dialog = MessageBox.Show(txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                txtMsg = this.vmEdit.EditJabatan(this.kodeJabatanTerpilih, this.txtNamaJabatan.Text);
                MessageBoxIcon icon = MessageBoxIcon.Information;
                if (txtMsg.ToLower().Contains("gagal"))
                    icon = MessageBoxIcon.Warning;
                MessageBox.Show(txtMsg, "Perhatian", MessageBoxButtons.OK, icon);
                this.UpdateDgv();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string txtMsg = "Hapus jabatan?";
            DialogResult dialog = MessageBox.Show(txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                txtMsg = this.vmEdit.DeleteJabatan(this.txtKodeJabatan.Text);
                MessageBoxIcon icon = MessageBoxIcon.Information;
                if (txtMsg.ToLower().Contains("gagal"))
                    icon = MessageBoxIcon.Warning;
                MessageBox.Show(txtMsg, "Perhatian", MessageBoxButtons.OK, icon);
                this.ClearForm();
                this.UpdateDgv();
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            string txtMsg = "Bersihkan form?";
            DialogResult dialog = MessageBox.Show(txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.ClearForm();
        }
    }
}
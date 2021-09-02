using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Absensi_RFID.User_Control
{
    public partial class Uc_LaporanAbsensi : UserControl, Config.IUserControl
    {
        private static Uc_LaporanAbsensi instance;
        public static Uc_LaporanAbsensi Instance { get { return (instance == null) ? instance = new Uc_LaporanAbsensi() : instance; } }
        private ViewModel.VM_Uc_LaporanAbsen vmLap = new ViewModel.VM_Uc_LaporanAbsen();
        private Report_View.Frm_Rpt_LapAbsensi rpt;
        private string[] bulan = new string[13]
        {
            "", " Januari ", " Februari ", " Maret ",
            " April ", " Mei ", " Juni ",
            " Juli ", " Agustus ", " September ",
            " Oktober ", " November ", " Desember "
        };
        private object kodeAdmin;
        private string tgl;
        private enum Lap { Harian, Bulanan, Tahunan}
        private Lap stsLap;

        public Uc_LaporanAbsensi()
        {
            InitializeComponent();
            this.btnHarian.Click += delegate { this.LaporanPer(this.stsLap = Lap.Harian); };
            this.btnBulanan.Click += delegate { this.LaporanPer(this.stsLap = Lap.Bulanan); };
            this.btnTahunan.Click += delegate { this.LaporanPer(this.stsLap = Lap.Tahunan); };
        }

        public void ResetForm(object kodeAdmin)
        {
            this.kodeAdmin = kodeAdmin;
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.groupBox1.Text = "";
            this.EnabledBtnLap(null);
            this.EnabledCmbTglLap(false, false, false);
            while(this.dgv.Rows.Count > 1)
                this.dgv.Rows.RemoveAt(0);
            this.txtJmlData.Text = "0";
            this.btnBuatLap.Enabled = false;
            this.btnClearForm.Enabled = false;
        }

        private void EnabledBtnLap(Button btn)
        {
            List<Button> button = new List<Button>() { this.btnHarian, this.btnBulanan, this.btnTahunan };
            for (int i = 0; i < button.Count; i++)
                button[i].BackColor = (button[i] == btn) ? Color.White : Color.LightCoral;
        }

        private void EnabledCmbTglLap(bool hr = true, bool bl = true, bool th = true)
        {
            this.cmbTgl.Enabled = hr;
            this.cmbBln.Enabled = bl;
            this.cmbThn.Enabled = th;
            this.cmbTgl.Text = "--Tgl--";
            this.cmbBln.Text = "--Bln--";
            this.cmbThn.Text = "--Thn--";
        }

        private void CmbTglLap(ComboBox cmb, int awal, int akhir)
        {
            if (cmb.Items.Count > 0)
                cmb.Items.Clear();

            string item;
            for (int i = awal; i <= akhir; i++)
            {
                item = i.ToString();
                cmb.Items.Add((item.Length < 2) ? $"0{item}" : item);
            }
        }

        private void LaporanPer(Lap lap)
        {
            if(lap == Lap.Harian)
            {
                this.EnabledBtnLap(this.btnHarian);
                this.CmbTglLap(this.cmbTgl, 1, 31);
                this.CmbTglLap(this.cmbBln, 1, 12);
                this.CmbTglLap(this.cmbThn, 2020, int.Parse(DateTime.Now.ToString("yyyy")));
                this.EnabledCmbTglLap();
            }
            else if(lap == Lap.Bulanan)
            {
                this.EnabledBtnLap(this.btnBulanan);
                this.CmbTglLap(this.cmbBln, 1, 12);
                this.CmbTglLap(this.cmbThn, 2020, int.Parse(DateTime.Now.ToString("yyyy")));
                this.EnabledCmbTglLap(hr : false);
            }
            else
            {
                this.EnabledBtnLap(this.btnTahunan);
                this.CmbTglLap(this.cmbThn, 2020, int.Parse(DateTime.Now.ToString("yyyy")));
                this.EnabledCmbTglLap(hr : false, bl : false);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.cmbThn.Enabled)
            {
                int sltTgl = this.cmbTgl.SelectedIndex;
                int sltBln = this.cmbBln.SelectedIndex;
                int sltThn = this.cmbThn.SelectedIndex;

                if (this.stsLap == Lap.Harian)
                {
                    if (sltTgl >= 0 && sltBln >= 0 && sltThn >= 0)
                        this.btnOke.Enabled = true;
                    else
                        this.btnOke.Enabled = false;
                }
                else if (this.stsLap == Lap.Bulanan)
                {
                    if (sltBln >= 0 && sltThn >= 0)
                        this.btnOke.Enabled = true;
                    else
                        this.btnOke.Enabled = false;
                }
                else
                {
                    if (this.cmbThn.SelectedIndex >= 0)
                        this.btnOke.Enabled = true;
                    else
                        this.btnOke.Enabled = false;
                }
            }
            else
                this.btnOke.Enabled = false;
        }

        private void UpdateDgv(string tgl)
        {
            this.dgv.DataSource = this.vmLap.GetDataLaporan(tgl);
            int jmlRow = this.dgv.Rows.Count - 1;
            for (int i = 0; i < jmlRow; i++)
                this.dgv.Rows[i].Cells["clmNo"].Value = i + 1;
            this.txtJmlData.Text = jmlRow.ToString();
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            int idxBln = 0;
            bool tpBln = int.TryParse(this.cmbBln.Text, out idxBln);
            idxBln = tpBln ? idxBln : 0;

            if (this.stsLap == Lap.Harian)
            {
                this.groupBox1.Text = $"Update Per : {this.cmbTgl.Text} {this.bulan[idxBln]} {this.cmbThn.Text}";
                this.tgl = $"{this.cmbThn.Text}/{this.cmbBln.Text}/{this.cmbTgl.Text}";
            }   
            else if(this.stsLap == Lap.Bulanan)
            {
                this.groupBox1.Text = $"Update Per : {this.bulan[idxBln]} {this.cmbThn.Text}";
                this.tgl = $"{this.cmbThn.Text}/{this.cmbBln.Text}";
            }
            else
            {
                this.groupBox1.Text = $"Update Per : {this.cmbThn.Text}";
                this.tgl = $"{this.cmbThn.Text}";
            }

            this.UpdateDgv(this.tgl);
            this.btnBuatLap.Enabled = true;
            this.btnClearForm.Enabled = true;
        }

        private void btnBuatLap_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Report_View.Frm_Rpt_LapAbsensi>().Any())
            {
                this.rpt = new Report_View.Frm_Rpt_LapAbsensi();
                this.rpt.Tgl = this.tgl;
                this.rpt.LapPer = this.groupBox1.Text;
                this.rpt.Admin = $"Admin : {this.vmLap.GetNamaAdmin(this.kodeAdmin)} ({this.kodeAdmin})";
                this.rpt.TotKaryawan = $"Total Absen : {this.txtJmlData.Text}";
                this.rpt.Show();
            }
            else
                this.rpt.Activate();
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
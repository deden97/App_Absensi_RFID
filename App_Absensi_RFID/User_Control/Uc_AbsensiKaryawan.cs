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
    public partial class Uc_AbsensiKaryawan : UserControl, Config.IUserControl
    {
        private static Uc_AbsensiKaryawan instance;
        public static Uc_AbsensiKaryawan Instance { get { return (instance == null) ? instance = new Uc_AbsensiKaryawan() : instance; } }
        private ViewModel.VM_Uc_AbsensiKaryawan vmAbsen = new ViewModel.VM_Uc_AbsensiKaryawan();
        private object kodeAdmin;
        private string txtMsg;
        private string tgl = DateTime.Now.ToString("yyyy/MM/dd");

        public Uc_AbsensiKaryawan()
        {
            InitializeComponent();
            this.tStatusAbsen.Tick += delegate { this.lblStatusAbsen.Visible = !this.lblStatusAbsen.Visible; };
        }

        public void ResetForm(object kodeAdmin)
        {
            this.kodeAdmin = kodeAdmin;
            this.UpdateDgv();
            this.RFIDClose();
            this.ClearForm();
        }

        private void RFIDClose()
        {
            Config.ConnectRFID.rfid.Close();
            this.lblStatusRFID.Text = "";
            this.cmbPortRFID.Items.Clear();
            this.tScanRFID.Stop();
            this.cmbPortRFID.Text = "--Hubungkan RFID--";
        }

        private void ClearForm()
        {
            this.txtKodeKaryawan.Clear();
            if(!Config.ConnectRFID.rfid.IsOpen)
                this.lblStatusRFID.Text = "";
            this.txtNamaLengkap.Clear();
            this.txtJabatan.Clear();
            this.pictureBox1.Image = Properties.Resources.profile_user;
            this.lblStatusAbsen.Text = "";
        }

        private void UpdateDgv()
        {
            this.dgv1.DataSource = this.vmAbsen.GetDataAbsen(this.tgl);
            int jmlRow = this.dgv1.Rows.Count - 1;
            for (int i = 0; i < jmlRow; i++)
                this.dgv1.Rows[i].Cells["clmNo"].Value = i + 1;
            this.txtTotAbsen.Text = jmlRow.ToString();
        }

        private void tPortRFID_Tick(object sender, EventArgs e)
        {
            string[] port = Config.ConnectRFID.GetPort;
            if(port.Length > this.cmbPortRFID.Items.Count)
            {
                this.cmbPortRFID.Items.Clear();
                foreach (var pt in port)
                    this.cmbPortRFID.Items.Add(pt);
                this.cmbPortRFID.Text = "--Pilih Port--";
            }

            if(port.Length < 1 && this.cmbPortRFID.Items.Count > 0)
            {
                this.cmbPortRFID.Items.Clear();
                this.cmbPortRFID.Text = "--RFID Tidak Terhubung--";
            }
        }

        private void tScanRFID_Tick(object sender, EventArgs e)
        {
            if (Config.ConnectRFID.rfid.IsOpen)
            {
                string kodeIn = Config.ConnectRFID.rfid.ReadExisting();
                if (this.vmAbsen.CekKodeIn(kodeIn))
                {
                    try
                    {
                        this.txtKodeKaryawan.Text = this.vmAbsen.KodeKaryawan;
                        this.txtNamaLengkap.Text = this.vmAbsen.Nama;
                        this.txtJabatan.Text = this.vmAbsen.Jabatan;
                        using (System.IO.MemoryStream mStream = new System.IO.MemoryStream(this.vmAbsen.Foto))
                            this.pictureBox1.Image = Image.FromStream(mStream);
                    }
                    catch (Exception err) { MessageBox.Show(err.ToString()); }
                }
                else
                {
                    if(kodeIn.Length >= 8)
                    {
                        this.ClearForm();
                        this.lblStatusAbsen.ForeColor = Color.Red;
                        this.lblStatusAbsen.Text = "Kode karyawan tidak terdaftar!";
                    }
                }
            }
            else
            {
                this.RFIDClose();
            }
        }

        private void cmbPortRFID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbPortRFID.Text.ToLower().Contains("com"))
            {
                try
                {
                    Config.ConnectRFID.rfid.PortName = this.cmbPortRFID.Text;
                    Config.ConnectRFID.rfid.BaudRate = 9600;
                    Config.ConnectRFID.rfid.DataBits = 8;
                    Config.ConnectRFID.rfid.Open();
                    if (Config.ConnectRFID.rfid.IsOpen)
                    {
                        this.lblStatusRFID.Text = "Scan kartu/tag ke RFID.";
                        this.tScanRFID.Start();
                        this.txtMsg = "RFID telah terhubung, silahkan scan kartu / tag ke RFID untuk absen.";
                        MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception err) { MessageBox.Show(err.ToString()); }
            }
        }

        private void btnCloseConnect_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Putuskan koneksi dengan RFID?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.RFIDClose();
                this.ClearForm();
            }
        }

        private void txtKodeKaryawan_TextChanged(object sender, EventArgs e)
        {
            if(this.txtKodeKaryawan.TextLength >= 8)
            {
                // melakukan pengecekan kode karyawan pada tb_absensi_karyawan sesuai dengan tgl hari ini,
                // jika belum tersedia lakukan perintah dibawah ini.
                this.lblStatusAbsen.ForeColor = Color.Black;
                if (!this.vmAbsen.CekAbsensiHariIni(this.txtKodeKaryawan.Text, this.tgl))
                {
                    this.lblStatusAbsen.Text = this.vmAbsen.SimpanAbsen(this.txtKodeKaryawan.Text);
                    this.UpdateDgv();
                }
                else
                {
                    this.lblStatusAbsen.Text = "Sudah Masuk Absen!";
                    this.UpdateDgv();
                }
            }
        }
    }
}
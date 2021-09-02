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
    public partial class Uc_TambahKaryawan : UserControl, Config.IUserControl
    {
        private static Uc_TambahKaryawan instance;
        public static Uc_TambahKaryawan Instance { get { return (instance == null) ? instance = new Uc_TambahKaryawan() : instance; } }
        private ViewModel.VM_Uc_TambahKaryawan vmTK = new ViewModel.VM_Uc_TambahKaryawan();
        private object kodeAdmin;
        private string txtErr, txtMsg, jenisKelamin;

        public Uc_TambahKaryawan()
        {
            InitializeComponent();
            this.rbLaki2.CheckedChanged += delegate { this.SetJK('L'); };
            this.rbPerempuan.CheckedChanged += delegate { this.SetJK('P'); };
            this.Load += delegate { this.tCekPortRFID.Start(); };
        }

        public void ResetForm(object kodeAdmin)
        {
            this.kodeAdmin = kodeAdmin;
            this.cmbJabatan.DataSource = this.vmTK.GetJabatan();
            this.cmbJabatan.DisplayMember = "NAMA_JABATAN";
            this.cmbJabatan.ValueMember = "KODE_JABATAN";
            this.RFIDClose();
            this.ClearForm();
        }

        public void RFIDClose()
        {
            this.tScanRFID.Stop();
            Config.ConnectRFID.rfid.Close();
            this.cmbPortRFID.Items.Clear();
            this.cmbPortRFID.Text = "--Hubungkan RFID--";
            this.lblStatusRFID.Text = "";
        }

        private void ClearForm()
        {
            this.txtKodeKaryawan.Clear();
            this.txtNamaLengkap.Clear();
            this.rbLaki2.Checked = false;
            this.rbPerempuan.Checked = false;
            this.SetJK('*');
            this.txtNoHp.Clear();
            this.cmbJabatan.SelectedIndex = 0;
            this.cmbJabatan.Enabled = false;
            this.pictureBox1.Image = Properties.Resources.profile_user;
            this.btnPilihFoto.Enabled = false;
            this.btnTambahKaryawan.Enabled = false;
        }

        private void tCekPortRFID_Tick(object sender, EventArgs e)
        {
            string[] port = Config.ConnectRFID.GetPort;
            if (port.Length > this.cmbPortRFID.Items.Count)
            {
                this.cmbPortRFID.Items.Clear();
                foreach(var pt in port)
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
            if(Config.ConnectRFID.rfid.IsOpen)
            {
                string readId = Config.ConnectRFID.rfid.ReadExisting();
                this.txtKodeKaryawan.Text = this.vmTK.CekKodeIn(readId, this.txtKodeKaryawan.Text);
            }
            else
            {
                this.RFIDClose();
            }
        }

        private void cmbPortRFID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbPortRFID.Text.ToUpper().Contains("COM"))
            {
                try
                {
                    Config.ConnectRFID.rfid.Close();
                    Config.ConnectRFID.rfid.PortName = this.cmbPortRFID.Text;
                    Config.ConnectRFID.rfid.BaudRate = 9600;
                    Config.ConnectRFID.rfid.DataBits = 8;
                    Config.ConnectRFID.rfid.Open();
                    if (Config.ConnectRFID.rfid.IsOpen)
                    {
                        this.lblStatusRFID.Text = "RFID Terhubung.";
                        this.txtMsg = "RFID telah terhubung, silahkan scan kartu ke RFID.";
                        MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.tScanRFID.Start();
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
            object[] result = this.vmTK.CekKodeKaryawan(this.txtKodeKaryawan.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtKodeKaryawan, this.txtErr);
            this.txtNamaLengkap.Enabled = Convert.ToBoolean(result[1]);
            if (this.txtNamaLengkap.Enabled)
                this.txtNamaLengkap.Focus();
        }

        private void txtNamaLengkap_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmTK.CekNama(this.txtNamaLengkap.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtNamaLengkap, this.txtErr);
            this.rbLaki2.Enabled = Convert.ToBoolean(result[1]);
            this.rbPerempuan.Enabled = Convert.ToBoolean(result[1]);
        }

        private void SetJK(char jk)
        {
            object[] result = this.vmTK.CekJenisKelamin(jk);
            this.jenisKelamin = result[0].ToString();
            this.txtNoHp.Enabled = Convert.ToBoolean(result[1]);
            this.txtNoHp.Focus();
        }

        private void txtNoHp_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmTK.CekNoHp(this.txtNoHp.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtNoHp, this.txtErr);
            this.cmbJabatan.Enabled = Convert.ToBoolean(result[1]);
        }

        private void cmbJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbJabatan.Enabled)
            {
                this.btnPilihFoto.Enabled = true;
                this.btnTambahKaryawan.Enabled = true;
            }
        }

        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            this.ofd1.Filter = "Image File(*.jpg; *.png) | *.jpg; *.png";
            if (this.ofd1.ShowDialog() == DialogResult.OK)
                this.pictureBox1.Image = Image.FromStream(this.ofd1.OpenFile());
        }

        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Tambah karyawan?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    string kk = this.txtKodeKaryawan.Text;
                    string terdaftar = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string nama = this.txtNamaLengkap.Text;
                    string jk = this.jenisKelamin;
                    string noHp = this.txtNoHp.Text;
                    string jbt = this.cmbJabatan.SelectedValue.ToString();
                    using (System.IO.MemoryStream mStream = new System.IO.MemoryStream())
                    {
                        this.pictureBox1.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Png);
                        this.txtMsg = this.vmTK.InsertKaryawan(kk, terdaftar, nama, jk, noHp, jbt, mStream.GetBuffer());
                        MessageBoxIcon icon = MessageBoxIcon.Information;
                        if (this.txtMsg.ToLower().Contains("gagal"))
                            icon = MessageBoxIcon.Warning;
                        MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, icon);
                    }
                }
                catch (Exception err) { MessageBox.Show(err.ToString()); }
            }
        }

        private void btnBersihkanForm_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Bersihkan form?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.ClearForm();
        }
    }
}
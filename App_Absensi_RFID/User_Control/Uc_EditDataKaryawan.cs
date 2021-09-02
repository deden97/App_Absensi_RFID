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
    public partial class Uc_EditDataKaryawan : UserControl, Config.IUserControl
    {
        private static Uc_EditDataKaryawan instance;
        public static Uc_EditDataKaryawan Instance { get { return (instance == null) ? instance = new Uc_EditDataKaryawan() : instance; } }
        private ViewModel.VM_Uc_EditDataKaryawan vmEdt = new ViewModel.VM_Uc_EditDataKaryawan();
        private object kodeAdmin;
        private string txtMsg, txtErr, jenisKelamin;
        private enum tab { EditData, GantiKartu}
        private tab stsTab = tab.EditData;
        private bool scanKodeSaatIni = false;

        public Uc_EditDataKaryawan()
        {
            InitializeComponent();
            this.tabControl1.Selected += delegate { this.SelectTab(); };
            this.tCekPortRFID.Start();
            this.rbLaki2.CheckedChanged += delegate { this.SetJK('L'); };
            this.rbPerempuan.CheckedChanged += delegate { this.SetJK('P'); };
        }

        public void ResetForm(object kodeAdmin)
        {
            this.kodeAdmin = kodeAdmin;
            this.tabControl1.SelectedTab = this.tabPage1;
            this.tabControl1.Enabled = false;
            this.cmbJabatan.DataSource = this.vmEdt.GetJabatan();
            this.cmbJabatan.ValueMember = "KODE_JABATAN";
            this.cmbJabatan.DisplayMember = "NAMA_JABATAN";
            this.RFIDClose();
            this.ClearForm1();
            this.ClearForm2();
        }

        private void SelectTab() => this.stsTab = (this.tabControl1.SelectedTab == this.tabPage1) ? tab.EditData : tab.GantiKartu;

        private void RFIDClose()
        {
            this.tScanRFID.Stop();
            Config.ConnectRFID.rfid.Close();
            this.cmbPortRFID.Items.Clear();
            this.cmbPortRFID.Text = "--Hubungkan RFID--";
            this.lblStatusRFID.Text = "";
        }

        private void tCekPortRFID_Tick(object sender, EventArgs e)
        {
            string[] port = Config.ConnectRFID.GetPort;
            if (port.Length > this.cmbPortRFID.Items.Count)
            {
                this.cmbPortRFID.Items.Clear();
                foreach (var pt in port)
                    this.cmbPortRFID.Items.Add(pt);
                this.cmbPortRFID.Text = "--Pilih Port--";
            }

            if (port.Length < 1 && this.cmbPortRFID.Items.Count > 0)
            {
                this.cmbPortRFID.Items.Clear();
                this.cmbPortRFID.Text = "--RFID Tidak Terhubung--";
            }  
        }

        // scan kartu / tag
        private void tScanRFID_Tick(object sender, EventArgs e)
        {
            if (Config.ConnectRFID.rfid.IsOpen)
            {
                string readId = Config.ConnectRFID.rfid.ReadExisting();
                if (this.stsTab == tab.EditData)
                {
                    if (this.vmEdt.CekKodeInDb(readId))
                        this.txtKodeKaryawan.Text = readId;
                }
                else
                {
                    if (this.scanKodeSaatIni == false)
                    {
                        if (this.vmEdt.CekKodeInDb(readId))
                        {
                            this.txtKodeSaatIni.Text = readId;
                            this.scanKodeSaatIni = true;
                        }
                    }
                    else
                    {
                        if (!this.vmEdt.CekKodeInDb(readId))
                            this.txtKodeKaryawanBaru.Text = this.vmEdt.CekKodeInBaru(readId, this.txtKodeKaryawanBaru.Text);
                    }
                }
            }
            else
            {
                this.RFIDClose();
                this.tabControl1.Enabled = false;
            }
        }

        // pilih port(COM) RFID
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
                        this.tScanRFID.Start();
                        this.txtMsg = "RFID telah terhubung, silahkan scan kartu / tag ke RFID untuk meng-edit data.";
                        MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.tabControl1.Enabled = true;
                    }
                    else
                    {
                        this.txtMsg = "Tidak dapat terhubung ke RFID, coba pilih port lain.";
                        MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception err) { MessageBox.Show(err.ToString()); }
            }
        }

        private void btnCloseConnect_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Putuskan koneksi dengan RFID?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.RFIDClose();
                this.tabControl1.Enabled = false;
                this.ClearForm1();
                this.ClearForm2();
            }
        }

        // Edit data karyawan ***************************************************************
        private void ClearForm1()
        {
            this.txtKodeKaryawan.Clear();
            this.txtNamaLengkap.Clear();
            this.rbLaki2.Checked = false;
            this.rbPerempuan.Checked = false;
            this.SetJK('*');
            this.txtNoHp.Clear();
            this.cmbJabatan.SelectedIndex = 0;
            this.pictureBox1.Image = Properties.Resources.profile_user;
            this.btnPilihFoto.Enabled = false;
            this.btnEditDataKaryawan.Enabled = false;
            this.btnHapusKaryawan.Enabled = false;
        }

        private void txtKodeKaryawan_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmEdt.CekKodeKaryawan(this.txtKodeKaryawan.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtKodeKaryawan, this.txtErr);
            this.txtNamaLengkap.Enabled = Convert.ToBoolean(result[1]);
            if (string.IsNullOrEmpty(this.txtErr))
            {
                this.txtNamaLengkap.Text = this.vmEdt.Nama;
                if (this.vmEdt.JK == "L")
                    this.rbLaki2.Checked = true;
                else
                    this.rbPerempuan.Checked = true;
                this.txtNoHp.Text = this.vmEdt.NoHp;
                this.cmbJabatan.SelectedValue = this.vmEdt.Jabatan;
                this.EnabledBtn();
                System.IO.MemoryStream mStream = new System.IO.MemoryStream(this.vmEdt.Foto);
                this.pictureBox1.Image = Image.FromStream(mStream);
            }
            else
                this.ClearForm1();
        }

        private void txtNamaLengkap_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmEdt.CekNama(this.txtNamaLengkap.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtNamaLengkap, this.txtErr);
            this.rbLaki2.Enabled = Convert.ToBoolean(result[1]);
            this.rbPerempuan.Enabled = Convert.ToBoolean(result[1]);
        }

        private void SetJK(char jk)
        {
            object[] result = this.vmEdt.CekJenisKelamin(jk);
            this.jenisKelamin = result[0].ToString();
            this.txtNoHp.Enabled = Convert.ToBoolean(result[1]);
        }

        private void txtNoHp_TextChanged(object sender, EventArgs e)
        {
            object[] result = this.vmEdt.CekNoHp(this.txtNoHp.Text);
            this.txtErr = result[0].ToString();
            this.errorProvider1.SetError(this.txtNoHp, this.txtErr);
            this.cmbJabatan.Enabled = Convert.ToBoolean(result[1]);
        }

        private void EnabledBtn()
        {
            if (this.cmbJabatan.Enabled)
            {
                this.btnPilihFoto.Enabled = true;
                this.btnEditDataKaryawan.Enabled = true;
                this.btnHapusKaryawan.Enabled = true;
            }
        }

        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            this.ofd1.Filter = "Image File(*.jpg; *.png) | *.jpg; *.png";
            if (this.ofd1.ShowDialog() == DialogResult.OK)
                this.pictureBox1.Image = Image.FromStream(this.ofd1.OpenFile());
        }

        private void btnEditDataKaryawan_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Edit data karyawan?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    string kode = this.txtKodeKaryawan.Text;
                    string nm = this.txtNamaLengkap.Text;
                    string jk = this.jenisKelamin;
                    string nohp = this.txtNoHp.Text;
                    string jbt = this.cmbJabatan.SelectedValue.ToString();
                    using (System.IO.MemoryStream mStream = new System.IO.MemoryStream())
                    {
                        this.pictureBox1.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Png);
                        this.txtMsg = this.vmEdt.EditDataKaryawan(kode, nm, jk, nohp, jbt, mStream.GetBuffer());
                        MessageBoxIcon icon = this.txtMsg.ToLower().Contains("gagal") ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
                        MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, icon);
                    }
                }
                catch(Exception err) { MessageBox.Show(err.ToString()); }
            }
        }

        private void btnHapusKaryawan_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Hapus data Karyawan? Karyawan yang telah dihapus akan hilang secara permanen.";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                this.txtMsg = this.vmEdt.HapusKaryawan(this.txtKodeKaryawan.Text);
                MessageBoxIcon icon = this.txtMsg.ToLower().Contains("gagal") ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
                MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, icon);
            }
        }

        private void btnBersihkanForm_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Bersihkan form?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.ClearForm1();
        }
        //**************************************************************** Edit data karyawan

        // Ganti kartu / tag / kode karyawan ************************************************
        private void ClearForm2()
        {
            this.txtKodeSaatIni.Clear();
            this.txtKodeKaryawanBaru.Clear();
            this.scanKodeSaatIni = false;
            this.btnGantiKartu.Enabled = false;
        }

        private void txtKodeSaatIni_TextChanged(object sender, EventArgs e)
        {
            this.txtMsg = this.vmEdt.CekKodeSaatIni(this.txtKodeSaatIni.Text);
            if (!string.IsNullOrEmpty(this.txtMsg))
            {
                MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnGantiKartu.Enabled = true;
            }
        }

        private void btnGantiKartu_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Ganti kartu / tag / kode Karyawan?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                string kodeSaatIni = this.txtKodeSaatIni.Text;
                string kodeBaru = this.txtKodeKaryawanBaru.Text;
                this.txtMsg = this.vmEdt.GantiKartu(kodeSaatIni, kodeBaru);
                MessageBoxIcon icon = this.txtMsg.ToLower().Contains("gagal") ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
                MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.OK, icon);
            }
        }

        private void btnBersihkanForm2_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Bersihkan form?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.ClearForm2();
        }
        //************************************************ Ganti kartu / tag / kode karyawan
    }
}
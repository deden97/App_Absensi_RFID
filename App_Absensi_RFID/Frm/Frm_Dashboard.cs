using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using App_Absensi_RFID.User_Control;

namespace App_Absensi_RFID
{
    public partial class Frm_Dashboard : Form
    {
        private Frm.Frm_Login fLogin;
        private MemoryStream mStream;
        private object kodeAdmin;
        private string txtMsg;
        private string[] hari = new string[7]
        {
            "Minggu, ", "Senin, ", "Selasa, ", "Rabu, ",
            "Kamis, ", "Jum'at, ", "Sabtu, "
        };
        private string[] bulan = new string[12]
        {
            " Januari ", " Februari ", " Maret ",
            " April ", " Mei ", " Juni ",
            " Juli ", " Agustus ", " September ",
            " Oktober ", " November ", " Desember "
        };
        private Uc_Dashboard dashboard = Uc_Dashboard.Instance;
        private Uc_TambahAkunAdmin menuBuatAkunAdmin = Uc_TambahAkunAdmin.Instance;
        private Uc_TambahKaryawan menuTambahKaryawan = Uc_TambahKaryawan.Instance;
        private Uc_TambahJabatan menuTambahJabatan = Uc_TambahJabatan.Instance;
        private Uc_EditDataAdmin menuEditDataAdm = Uc_EditDataAdmin.Instance;
        private Uc_EditDataKaryawan menuEdiDataKaryawan = Uc_EditDataKaryawan.Instance;
        private Uc_EditJabatan menuEditJabatan = Uc_EditJabatan.Instance;
        private Uc_AbsensiKaryawan menuAbsensiKaryawan = Uc_AbsensiKaryawan.Instance;
        private Uc_LaporanAbsensi menuLapAbsensi = Uc_LaporanAbsensi.Instance;

        public Frm_Dashboard()
        {
            InitializeComponent();
            this.label1.Click += delegate { this.ShowMenu(this.dashboard); };
            this.tWaktu.Start();
            this.tTitik2.Start();
            this.tTitik2.Tick += delegate { this.lblTitik2.Visible = !this.lblTitik2.Visible; };
            this.ClearForm();
            this.tsExit.Click += delegate { Application.Exit(); };
            this.Load += delegate { this.tLogin.Start(); };
        }

        private void ShowMenu(Control ctl)
        {
            if (!this.pnlMenu.Controls.Contains(ctl))
            {
                this.pnlMenu.Controls.Add(ctl);
                ctl.Dock = DockStyle.Fill;

                List<Control> listControl = new List<Control>()
                {
                    this.dashboard,
                    this.menuBuatAkunAdmin,
                    this.menuTambahKaryawan,
                    this.menuTambahJabatan,
                    this.menuEditDataAdm,
                    this.menuEdiDataKaryawan,
                    this.menuEditJabatan,
                    this.menuAbsensiKaryawan,
                    this.menuLapAbsensi
                };

                for (int i = 0; i < listControl.Count; i++)
                {
                    Control control = listControl[i];
                    if (this.pnlMenu.Controls.Contains(control))
                    {
                        if (control != ctl)
                            this.pnlMenu.Controls.Remove(control);
                    }
                }

                // mengaktifkan timer edit data admin
                if (ctl == this.menuEditDataAdm)
                    this.tEditData.Start();
                else
                    this.tEditData.Stop();
            }
        }

        private void ClearForm()
        {
            this.kodeAdmin = null;
            this.menuStrip1.Enabled = false;
            this.pictureBox.Image = Properties.Resources.profile_user;
            this.lblKodeAdmin.Text = "";
            this.lblNamaAdmin.Text = "";
            this.ShowMenu(this.dashboard);
            this.tLogin.Start();
        }

        // proses login
        private void tLogin_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Frm.Frm_Login>().Any())
            {
                if (this.fLogin.BatalLogin)
                    Application.Exit();

                if (this.fLogin.Login)
                {
                    this.Activate();
                    this.menuStrip1.Enabled = true;
                    this.kodeAdmin = this.fLogin.KodeAdmin;
                    this.tLogin.Stop();
                    this.SetInfoAdmin(this.kodeAdmin.ToString(), this.fLogin.NamaAdmin.ToString(), this.fLogin.Foto);
                    this.fLogin.Close();
                }
            }
            else
            {
                this.fLogin = new Frm.Frm_Login();
                this.fLogin.Show();
            }
        }

        private void SetInfoAdmin(string kodeAdmin, string namaAdmin, byte[] foto)
        {
            this.lblKodeAdmin.Text = kodeAdmin;
            this.lblNamaAdmin.Text = namaAdmin;
            this.mStream = new MemoryStream(foto);
            this.pictureBox.Image = Image.FromStream(this.mStream);
            this.mStream.Close();
        }

        private void tWaktu_Tick(object sender, EventArgs e)
        {
            // jam menit
            this.lblJam.Text = DateTime.Now.ToString("hh");
            int jam24 = Convert.ToInt32(DateTime.Now.ToString("HH"));
            this.lblMenit.Text = DateTime.Now.ToString("mm");
            this.lblMenit.Text += (jam24 >= 0 && jam24 < 12) ? " AM" : " PM";

            // hari, tgl bulan tahun
            string tgl = $"{this.hari[(int)DateTime.Now.DayOfWeek]}{DateTime.Now.ToString("dd")}" + 
                         $"{this.bulan[(int)DateTime.Now.Month - 1]}{DateTime.Now.ToString("yyyy")}";
            if (this.lblTanggal.Text != tgl)
                this.lblTanggal.Text = tgl;
        }

        // tambah / daftar admin baru
        private void adminBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMenu(this.menuBuatAkunAdmin);
            this.menuBuatAkunAdmin.ResetForm(this.kodeAdmin);
        }

        // tambah / daftar karyawan
        private void karyawanBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMenu(this.menuTambahKaryawan);
            this.menuTambahKaryawan.ResetForm(this.kodeAdmin);
        }

        // tambah jabatan
        private void jabatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMenu(this.menuTambahJabatan);
            this.menuTambahJabatan.ResetForm(this.kodeAdmin);
        }

        // logout
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtMsg = "Anda yakin akan logout?";
            DialogResult dialog = MessageBox.Show(this.txtMsg, "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.ClearForm();
        }

        //*** edit data admin
        private void dataAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMenu(this.menuEditDataAdm);
            this.menuEditDataAdm.ResetForm(this.kodeAdmin);
            this.tEditData.Start();
        }

        private void tEditData_Tick(object sender, EventArgs e)
        {
            if (this.menuEditDataAdm.UpdateData)
            {
                this.SetInfoAdmin(this.menuEditDataAdm.GetKodeAdmin, this.menuEditDataAdm.GetNama, this.menuEditDataAdm.GetFoto);
                this.menuEditDataAdm.UpdateData = false;
            }
        }
        // edit data admin ***

        // edit data karyawan
        private void dataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMenu(this.menuEdiDataKaryawan);
            this.menuEdiDataKaryawan.ResetForm(this.kodeAdmin);
        }

        // edit data jabatan
        private void dataJabatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMenu(this.menuEditJabatan);
            this.menuEditJabatan.ResetForm(this.kodeAdmin);
        }

        // absensi karyawan
        private void absensiKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMenu(this.menuAbsensiKaryawan);
            this.menuAbsensiKaryawan.ResetForm(this.kodeAdmin);
        }

        // laporan absensi karyawan
        private void laporanAbsensiPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMenu(this.menuLapAbsensi);
            this.menuLapAbsensi.ResetForm(this.kodeAdmin);
        }
    }
}
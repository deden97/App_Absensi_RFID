
namespace App_Absensi_RFID
{
    partial class Frm_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karyawanBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jabatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataJabatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absensiKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanAbsensiPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitik2 = new System.Windows.Forms.Label();
            this.lblMenit = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKodeAdmin = new System.Windows.Forms.Label();
            this.lblNamaAdmin = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tLogin = new System.Windows.Forms.Timer(this.components);
            this.tWaktu = new System.Windows.Forms.Timer(this.components);
            this.tTitik2 = new System.Windows.Forms.Timer(this.components);
            this.tEditData = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.absensiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1077, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminBaruToolStripMenuItem,
            this.karyawanBaruToolStripMenuItem,
            this.jabatanToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.addToolStripMenuItem.Text = "Tambah";
            // 
            // adminBaruToolStripMenuItem
            // 
            this.adminBaruToolStripMenuItem.Name = "adminBaruToolStripMenuItem";
            this.adminBaruToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.adminBaruToolStripMenuItem.Text = "Buat Akun Admin";
            this.adminBaruToolStripMenuItem.Click += new System.EventHandler(this.adminBaruToolStripMenuItem_Click);
            // 
            // karyawanBaruToolStripMenuItem
            // 
            this.karyawanBaruToolStripMenuItem.Name = "karyawanBaruToolStripMenuItem";
            this.karyawanBaruToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.karyawanBaruToolStripMenuItem.Text = "Data Karyawan Baru";
            this.karyawanBaruToolStripMenuItem.Click += new System.EventHandler(this.karyawanBaruToolStripMenuItem_Click);
            // 
            // jabatanToolStripMenuItem
            // 
            this.jabatanToolStripMenuItem.Name = "jabatanToolStripMenuItem";
            this.jabatanToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.jabatanToolStripMenuItem.Text = "Jabatan Baru";
            this.jabatanToolStripMenuItem.Click += new System.EventHandler(this.jabatanToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(144, 26);
            this.tsExit.Text = "Keluar";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataAdminToolStripMenuItem,
            this.dataKaryawanToolStripMenuItem,
            this.dataJabatanToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dataAdminToolStripMenuItem
            // 
            this.dataAdminToolStripMenuItem.Name = "dataAdminToolStripMenuItem";
            this.dataAdminToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.dataAdminToolStripMenuItem.Text = "Data Admin / Akun";
            this.dataAdminToolStripMenuItem.Click += new System.EventHandler(this.dataAdminToolStripMenuItem_Click);
            // 
            // dataKaryawanToolStripMenuItem
            // 
            this.dataKaryawanToolStripMenuItem.Name = "dataKaryawanToolStripMenuItem";
            this.dataKaryawanToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.dataKaryawanToolStripMenuItem.Text = "Data Karyawan";
            this.dataKaryawanToolStripMenuItem.Click += new System.EventHandler(this.dataKaryawanToolStripMenuItem_Click);
            // 
            // dataJabatanToolStripMenuItem
            // 
            this.dataJabatanToolStripMenuItem.Name = "dataJabatanToolStripMenuItem";
            this.dataJabatanToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.dataJabatanToolStripMenuItem.Text = "Data Jabatan";
            this.dataJabatanToolStripMenuItem.Click += new System.EventHandler(this.dataJabatanToolStripMenuItem_Click);
            // 
            // absensiToolStripMenuItem
            // 
            this.absensiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absensiKaryawanToolStripMenuItem,
            this.laporanAbsensiPegawaiToolStripMenuItem});
            this.absensiToolStripMenuItem.Name = "absensiToolStripMenuItem";
            this.absensiToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.absensiToolStripMenuItem.Text = "Absensi";
            // 
            // absensiKaryawanToolStripMenuItem
            // 
            this.absensiKaryawanToolStripMenuItem.Name = "absensiKaryawanToolStripMenuItem";
            this.absensiKaryawanToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.absensiKaryawanToolStripMenuItem.Text = "Absensi Karyawan";
            this.absensiKaryawanToolStripMenuItem.Click += new System.EventHandler(this.absensiKaryawanToolStripMenuItem_Click);
            // 
            // laporanAbsensiPegawaiToolStripMenuItem
            // 
            this.laporanAbsensiPegawaiToolStripMenuItem.Name = "laporanAbsensiPegawaiToolStripMenuItem";
            this.laporanAbsensiPegawaiToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.laporanAbsensiPegawaiToolStripMenuItem.Text = "Laporan Absensi Karyawan";
            this.laporanAbsensiPegawaiToolStripMenuItem.Click += new System.EventHandler(this.laporanAbsensiPegawaiToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitik2);
            this.panel1.Controls.Add(this.lblMenit);
            this.panel1.Controls.Add(this.lblJam);
            this.panel1.Controls.Add(this.lblTanggal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblKodeAdmin);
            this.panel1.Controls.Add(this.lblNamaAdmin);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 74);
            this.panel1.TabIndex = 1;
            // 
            // lblTitik2
            // 
            this.lblTitik2.AutoSize = true;
            this.lblTitik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitik2.Location = new System.Drawing.Point(856, 16);
            this.lblTitik2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitik2.Name = "lblTitik2";
            this.lblTitik2.Size = new System.Drawing.Size(15, 24);
            this.lblTitik2.TabIndex = 7;
            this.lblTitik2.Text = ":";
            // 
            // lblMenit
            // 
            this.lblMenit.AutoSize = true;
            this.lblMenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenit.Location = new System.Drawing.Point(866, 16);
            this.lblMenit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenit.Name = "lblMenit";
            this.lblMenit.Size = new System.Drawing.Size(30, 24);
            this.lblMenit.TabIndex = 6;
            this.lblMenit.Text = "00";
            // 
            // lblJam
            // 
            this.lblJam.AutoSize = true;
            this.lblJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJam.Location = new System.Drawing.Point(833, 16);
            this.lblJam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(30, 24);
            this.lblJam.TabIndex = 5;
            this.lblJam.Text = "00";
            this.lblJam.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(833, 40);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(79, 24);
            this.lblTanggal.TabIndex = 4;
            this.lblTanggal.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "App Absensi";
            // 
            // lblKodeAdmin
            // 
            this.lblKodeAdmin.AutoSize = true;
            this.lblKodeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeAdmin.Location = new System.Drawing.Point(78, 29);
            this.lblKodeAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKodeAdmin.Name = "lblKodeAdmin";
            this.lblKodeAdmin.Size = new System.Drawing.Size(88, 18);
            this.lblKodeAdmin.TabIndex = 2;
            this.lblKodeAdmin.Text = "Kode Admin";
            // 
            // lblNamaAdmin
            // 
            this.lblNamaAdmin.AutoSize = true;
            this.lblNamaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaAdmin.Location = new System.Drawing.Point(78, 50);
            this.lblNamaAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaAdmin.Name = "lblNamaAdmin";
            this.lblNamaAdmin.Size = new System.Drawing.Size(153, 18);
            this.lblNamaAdmin.TabIndex = 1;
            this.lblNamaAdmin.Text = "Nama Lengkap Admin";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::App_Absensi_RFID.Properties.Resources.profile_user;
            this.pictureBox.Location = new System.Drawing.Point(4, 4);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(67, 64);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Location = new System.Drawing.Point(0, 98);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1077, 587);
            this.pnlMenu.TabIndex = 2;
            // 
            // tLogin
            // 
            this.tLogin.Tick += new System.EventHandler(this.tLogin_Tick);
            // 
            // tWaktu
            // 
            this.tWaktu.Interval = 1000;
            this.tWaktu.Tick += new System.EventHandler(this.tWaktu_Tick);
            // 
            // tTitik2
            // 
            this.tTitik2.Interval = 500;
            // 
            // tEditData
            // 
            this.tEditData.Interval = 1000;
            this.tEditData.Tick += new System.EventHandler(this.tEditData_Tick);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1077, 685);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Absensi RFID";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem absensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absensiKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karyawanBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jabatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataJabatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanAbsensiPegawaiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblNamaAdmin;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Timer tLogin;
        private System.Windows.Forms.Label lblKodeAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Timer tWaktu;
        private System.Windows.Forms.Label lblTitik2;
        private System.Windows.Forms.Label lblMenit;
        private System.Windows.Forms.Timer tTitik2;
        private System.Windows.Forms.Timer tEditData;
    }
}



namespace App_Absensi_RFID.User_Control
{
    partial class Uc_EditDataKaryawan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatusRFID = new System.Windows.Forms.Label();
            this.cmbPortRFID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBersihkanForm = new System.Windows.Forms.Button();
            this.btnEditDataKaryawan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKodeKaryawan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPilihFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbJabatan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLaki2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.tCekPortRFID = new System.Windows.Forms.Timer(this.components);
            this.tScanRFID = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBersihkanForm2 = new System.Windows.Forms.Button();
            this.btnGantiKartu = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtKodeKaryawanBaru = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtKodeSaatIni = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCloseConnect = new System.Windows.Forms.Button();
            this.btnHapusKaryawan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Data Karyawan";
            // 
            // lblStatusRFID
            // 
            this.lblStatusRFID.AutoSize = true;
            this.lblStatusRFID.Location = new System.Drawing.Point(594, 62);
            this.lblStatusRFID.Name = "lblStatusRFID";
            this.lblStatusRFID.Size = new System.Drawing.Size(101, 20);
            this.lblStatusRFID.TabIndex = 74;
            this.lblStatusRFID.Text = "Status RFID";
            // 
            // cmbPortRFID
            // 
            this.cmbPortRFID.FormattingEnabled = true;
            this.cmbPortRFID.Location = new System.Drawing.Point(186, 58);
            this.cmbPortRFID.Name = "cmbPortRFID";
            this.cmbPortRFID.Size = new System.Drawing.Size(402, 28);
            this.cmbPortRFID.TabIndex = 73;
            this.cmbPortRFID.Text = "--Hubungkan RFID--";
            this.cmbPortRFID.SelectedIndexChanged += new System.EventHandler(this.cmbPortRFID_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 71;
            this.label13.Text = "Port RFID";
            // 
            // btnBersihkanForm
            // 
            this.btnBersihkanForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBersihkanForm.Location = new System.Drawing.Point(482, 351);
            this.btnBersihkanForm.Name = "btnBersihkanForm";
            this.btnBersihkanForm.Size = new System.Drawing.Size(137, 32);
            this.btnBersihkanForm.TabIndex = 70;
            this.btnBersihkanForm.Text = "Bersihkan Form";
            this.btnBersihkanForm.UseVisualStyleBackColor = true;
            this.btnBersihkanForm.Click += new System.EventHandler(this.btnBersihkanForm_Click);
            // 
            // btnEditDataKaryawan
            // 
            this.btnEditDataKaryawan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDataKaryawan.Enabled = false;
            this.btnEditDataKaryawan.Location = new System.Drawing.Point(160, 351);
            this.btnEditDataKaryawan.Name = "btnEditDataKaryawan";
            this.btnEditDataKaryawan.Size = new System.Drawing.Size(165, 32);
            this.btnEditDataKaryawan.TabIndex = 69;
            this.btnEditDataKaryawan.Text = "Edit Data Karyawan";
            this.btnEditDataKaryawan.UseVisualStyleBackColor = true;
            this.btnEditDataKaryawan.Click += new System.EventHandler(this.btnEditDataKaryawan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = ":";
            // 
            // txtKodeKaryawan
            // 
            this.txtKodeKaryawan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKodeKaryawan.Enabled = false;
            this.txtKodeKaryawan.Location = new System.Drawing.Point(160, 5);
            this.txtKodeKaryawan.Name = "txtKodeKaryawan";
            this.txtKodeKaryawan.Size = new System.Drawing.Size(402, 27);
            this.txtKodeKaryawan.TabIndex = 67;
            this.txtKodeKaryawan.TextChanged += new System.EventHandler(this.txtKodeKaryawan_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 66;
            this.label11.Text = "Kode Karyawan";
            // 
            // btnPilihFoto
            // 
            this.btnPilihFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilihFoto.Enabled = false;
            this.btnPilihFoto.Location = new System.Drawing.Point(310, 168);
            this.btnPilihFoto.Name = "btnPilihFoto";
            this.btnPilihFoto.Size = new System.Drawing.Size(118, 32);
            this.btnPilihFoto.TabIndex = 65;
            this.btnPilihFoto.Text = "Pilih Foto";
            this.btnPilihFoto.UseVisualStyleBackColor = true;
            this.btnPilihFoto.Click += new System.EventHandler(this.btnPilihFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::App_Absensi_RFID.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(160, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(142, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 62;
            this.label15.Text = "Foto";
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.Enabled = false;
            this.cmbJabatan.FormattingEnabled = true;
            this.cmbJabatan.Location = new System.Drawing.Point(160, 134);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(402, 28);
            this.cmbJabatan.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Jabatan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = ":";
            // 
            // txtNoHp
            // 
            this.txtNoHp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNoHp.Enabled = false;
            this.txtNoHp.Location = new System.Drawing.Point(160, 101);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(402, 27);
            this.txtNoHp.TabIndex = 57;
            this.txtNoHp.TextChanged += new System.EventHandler(this.txtNoHp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "No. HP.";
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbPerempuan.Enabled = false;
            this.rbPerempuan.Location = new System.Drawing.Point(274, 71);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(115, 24);
            this.rbPerempuan.TabIndex = 55;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = false;
            // 
            // rbLaki2
            // 
            this.rbLaki2.AutoSize = true;
            this.rbLaki2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbLaki2.Enabled = false;
            this.rbLaki2.Location = new System.Drawing.Point(160, 71);
            this.rbLaki2.Name = "rbLaki2";
            this.rbLaki2.Size = new System.Drawing.Size(108, 24);
            this.rbLaki2.TabIndex = 54;
            this.rbLaki2.TabStop = true;
            this.rbLaki2.Text = "Laki - Laki";
            this.rbLaki2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = ":";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNamaLengkap.Enabled = false;
            this.txtNamaLengkap.Location = new System.Drawing.Point(160, 38);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(402, 27);
            this.txtNamaLengkap.TabIndex = 50;
            this.txtNamaLengkap.TextChanged += new System.EventHandler(this.txtNamaLengkap_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nama Lengkap";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ofd1
            // 
            this.ofd1.Title = "Pilih Foto";
            // 
            // tCekPortRFID
            // 
            this.tCekPortRFID.Interval = 500;
            this.tCekPortRFID.Tick += new System.EventHandler(this.tCekPortRFID_Tick);
            // 
            // tScanRFID
            // 
            this.tScanRFID.Interval = 500;
            this.tScanRFID.Tick += new System.EventHandler(this.tScanRFID_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 422);
            this.tabControl1.TabIndex = 75;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnHapusKaryawan);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNamaLengkap);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnBersihkanForm);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtKodeKaryawan);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnEditDataKaryawan);
            this.tabPage1.Controls.Add(this.rbLaki2);
            this.tabPage1.Controls.Add(this.rbPerempuan);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtNoHp);
            this.tabPage1.Controls.Add(this.btnPilihFoto);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.cmbJabatan);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edit Informasi Karyawan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnBersihkanForm2);
            this.tabPage2.Controls.Add(this.btnGantiKartu);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.txtKodeKaryawanBaru);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtKodeSaatIni);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ganti Kartu / Tag";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBersihkanForm2
            // 
            this.btnBersihkanForm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBersihkanForm2.Location = new System.Drawing.Point(421, 111);
            this.btnBersihkanForm2.Name = "btnBersihkanForm2";
            this.btnBersihkanForm2.Size = new System.Drawing.Size(159, 32);
            this.btnBersihkanForm2.TabIndex = 76;
            this.btnBersihkanForm2.Text = "Bersihkan Form";
            this.btnBersihkanForm2.UseVisualStyleBackColor = true;
            this.btnBersihkanForm2.Click += new System.EventHandler(this.btnBersihkanForm2_Click);
            // 
            // btnGantiKartu
            // 
            this.btnGantiKartu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGantiKartu.Enabled = false;
            this.btnGantiKartu.Location = new System.Drawing.Point(233, 111);
            this.btnGantiKartu.Name = "btnGantiKartu";
            this.btnGantiKartu.Size = new System.Drawing.Size(182, 32);
            this.btnGantiKartu.TabIndex = 75;
            this.btnGantiKartu.Text = "Ganti Kartu / Tag";
            this.btnGantiKartu.UseVisualStyleBackColor = true;
            this.btnGantiKartu.Click += new System.EventHandler(this.btnGantiKartu_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 20);
            this.label18.TabIndex = 72;
            this.label18.Text = "Kode Karyawan Baru";
            // 
            // txtKodeKaryawanBaru
            // 
            this.txtKodeKaryawanBaru.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKodeKaryawanBaru.Enabled = false;
            this.txtKodeKaryawanBaru.Location = new System.Drawing.Point(233, 68);
            this.txtKodeKaryawanBaru.Name = "txtKodeKaryawanBaru";
            this.txtKodeKaryawanBaru.Size = new System.Drawing.Size(402, 27);
            this.txtKodeKaryawanBaru.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(215, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 20);
            this.label19.TabIndex = 74;
            this.label19.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 20);
            this.label16.TabIndex = 69;
            this.label16.Text = "Kode Karyawan Saat Ini";
            // 
            // txtKodeSaatIni
            // 
            this.txtKodeSaatIni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKodeSaatIni.Enabled = false;
            this.txtKodeSaatIni.Location = new System.Drawing.Point(233, 35);
            this.txtKodeSaatIni.Name = "txtKodeSaatIni";
            this.txtKodeSaatIni.Size = new System.Drawing.Size(402, 27);
            this.txtKodeSaatIni.TabIndex = 70;
            this.txtKodeSaatIni.TextChanged += new System.EventHandler(this.txtKodeSaatIni_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(215, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 20);
            this.label17.TabIndex = 71;
            this.label17.Text = ":";
            // 
            // btnCloseConnect
            // 
            this.btnCloseConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseConnect.Location = new System.Drawing.Point(185, 92);
            this.btnCloseConnect.Name = "btnCloseConnect";
            this.btnCloseConnect.Size = new System.Drawing.Size(159, 32);
            this.btnCloseConnect.TabIndex = 77;
            this.btnCloseConnect.Text = "Putuskan Koneksi";
            this.btnCloseConnect.UseVisualStyleBackColor = true;
            this.btnCloseConnect.Click += new System.EventHandler(this.btnCloseConnect_Click);
            // 
            // btnHapusKaryawan
            // 
            this.btnHapusKaryawan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusKaryawan.Enabled = false;
            this.btnHapusKaryawan.Location = new System.Drawing.Point(331, 351);
            this.btnHapusKaryawan.Name = "btnHapusKaryawan";
            this.btnHapusKaryawan.Size = new System.Drawing.Size(145, 32);
            this.btnHapusKaryawan.TabIndex = 71;
            this.btnHapusKaryawan.Text = "Hapus Karyawan";
            this.btnHapusKaryawan.UseVisualStyleBackColor = true;
            this.btnHapusKaryawan.Click += new System.EventHandler(this.btnHapusKaryawan_Click);
            // 
            // Uc_EditDataKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnCloseConnect);
            this.Controls.Add(this.cmbPortRFID);
            this.Controls.Add(this.lblStatusRFID);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_EditDataKaryawan";
            this.Size = new System.Drawing.Size(865, 581);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatusRFID;
        private System.Windows.Forms.ComboBox cmbPortRFID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBersihkanForm;
        private System.Windows.Forms.Button btnEditDataKaryawan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKodeKaryawan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPilihFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbJabatan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLaki2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Timer tCekPortRFID;
        private System.Windows.Forms.Timer tScanRFID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtKodeSaatIni;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtKodeKaryawanBaru;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnBersihkanForm2;
        private System.Windows.Forms.Button btnGantiKartu;
        private System.Windows.Forms.Button btnCloseConnect;
        private System.Windows.Forms.Button btnHapusKaryawan;
    }
}

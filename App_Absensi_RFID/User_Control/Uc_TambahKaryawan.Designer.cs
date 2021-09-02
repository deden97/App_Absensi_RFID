
namespace App_Absensi_RFID.User_Control
{
    partial class Uc_TambahKaryawan
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbJabatan = new System.Windows.Forms.ComboBox();
            this.btnPilihFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKodeKaryawan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBersihkanForm = new System.Windows.Forms.Button();
            this.btnTambahKaryawan = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPortRFID = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.tCekPortRFID = new System.Windows.Forms.Timer(this.components);
            this.tScanRFID = new System.Windows.Forms.Timer(this.components);
            this.lblStatusRFID = new System.Windows.Forms.Label();
            this.btnCloseConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tambah Karyawan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = ":";
            // 
            // txtNoHp
            // 
            this.txtNoHp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNoHp.Enabled = false;
            this.txtNoHp.Location = new System.Drawing.Point(190, 245);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(402, 27);
            this.txtNoHp.TabIndex = 24;
            this.txtNoHp.TextChanged += new System.EventHandler(this.txtNoHp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "No. HP.";
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbPerempuan.Enabled = false;
            this.rbPerempuan.Location = new System.Drawing.Point(304, 215);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(115, 24);
            this.rbPerempuan.TabIndex = 22;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = false;
            // 
            // rbLaki2
            // 
            this.rbLaki2.AutoSize = true;
            this.rbLaki2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbLaki2.Enabled = false;
            this.rbLaki2.Location = new System.Drawing.Point(190, 215);
            this.rbLaki2.Name = "rbLaki2";
            this.rbLaki2.Size = new System.Drawing.Size(108, 24);
            this.rbLaki2.TabIndex = 21;
            this.rbLaki2.TabStop = true;
            this.rbLaki2.Text = "Laki - Laki";
            this.rbLaki2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = ":";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNamaLengkap.Enabled = false;
            this.txtNamaLengkap.Location = new System.Drawing.Point(190, 182);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(402, 27);
            this.txtNamaLengkap.TabIndex = 17;
            this.txtNamaLengkap.TextChanged += new System.EventHandler(this.txtNamaLengkap_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama Lengkap";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Jabatan";
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.Enabled = false;
            this.cmbJabatan.FormattingEnabled = true;
            this.cmbJabatan.Location = new System.Drawing.Point(190, 278);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(402, 28);
            this.cmbJabatan.TabIndex = 29;
            this.cmbJabatan.SelectedIndexChanged += new System.EventHandler(this.cmbJabatan_SelectedIndexChanged);
            // 
            // btnPilihFoto
            // 
            this.btnPilihFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilihFoto.Enabled = false;
            this.btnPilihFoto.Location = new System.Drawing.Point(340, 312);
            this.btnPilihFoto.Name = "btnPilihFoto";
            this.btnPilihFoto.Size = new System.Drawing.Size(118, 32);
            this.btnPilihFoto.TabIndex = 38;
            this.btnPilihFoto.Text = "Pilih Foto";
            this.btnPilihFoto.UseVisualStyleBackColor = true;
            this.btnPilihFoto.Click += new System.EventHandler(this.btnPilihFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::App_Absensi_RFID.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(190, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(172, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Foto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = ":";
            // 
            // txtKodeKaryawan
            // 
            this.txtKodeKaryawan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKodeKaryawan.Enabled = false;
            this.txtKodeKaryawan.Location = new System.Drawing.Point(190, 149);
            this.txtKodeKaryawan.Name = "txtKodeKaryawan";
            this.txtKodeKaryawan.Size = new System.Drawing.Size(402, 27);
            this.txtKodeKaryawan.TabIndex = 40;
            this.txtKodeKaryawan.TextChanged += new System.EventHandler(this.txtKodeKaryawan_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Kode Karyawan";
            // 
            // btnBersihkanForm
            // 
            this.btnBersihkanForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBersihkanForm.Location = new System.Drawing.Point(378, 495);
            this.btnBersihkanForm.Name = "btnBersihkanForm";
            this.btnBersihkanForm.Size = new System.Drawing.Size(159, 32);
            this.btnBersihkanForm.TabIndex = 43;
            this.btnBersihkanForm.Text = "Bersihkan Form";
            this.btnBersihkanForm.UseVisualStyleBackColor = true;
            this.btnBersihkanForm.Click += new System.EventHandler(this.btnBersihkanForm_Click);
            // 
            // btnTambahKaryawan
            // 
            this.btnTambahKaryawan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahKaryawan.Enabled = false;
            this.btnTambahKaryawan.Location = new System.Drawing.Point(190, 495);
            this.btnTambahKaryawan.Name = "btnTambahKaryawan";
            this.btnTambahKaryawan.Size = new System.Drawing.Size(182, 32);
            this.btnTambahKaryawan.TabIndex = 42;
            this.btnTambahKaryawan.Text = "Tambah Karyawan";
            this.btnTambahKaryawan.UseVisualStyleBackColor = true;
            this.btnTambahKaryawan.Click += new System.EventHandler(this.btnTambahKaryawan_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Port RFID";
            // 
            // cmbPortRFID
            // 
            this.cmbPortRFID.FormattingEnabled = true;
            this.cmbPortRFID.Location = new System.Drawing.Point(190, 67);
            this.cmbPortRFID.Name = "cmbPortRFID";
            this.cmbPortRFID.Size = new System.Drawing.Size(402, 28);
            this.cmbPortRFID.TabIndex = 47;
            this.cmbPortRFID.Text = "--Hubungkan RFID--";
            this.cmbPortRFID.SelectedIndexChanged += new System.EventHandler(this.cmbPortRFID_SelectedIndexChanged);
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
            // lblStatusRFID
            // 
            this.lblStatusRFID.AutoSize = true;
            this.lblStatusRFID.Location = new System.Drawing.Point(598, 71);
            this.lblStatusRFID.Name = "lblStatusRFID";
            this.lblStatusRFID.Size = new System.Drawing.Size(101, 20);
            this.lblStatusRFID.TabIndex = 48;
            this.lblStatusRFID.Text = "Status RFID";
            // 
            // btnCloseConnect
            // 
            this.btnCloseConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseConnect.Location = new System.Drawing.Point(190, 101);
            this.btnCloseConnect.Name = "btnCloseConnect";
            this.btnCloseConnect.Size = new System.Drawing.Size(159, 32);
            this.btnCloseConnect.TabIndex = 78;
            this.btnCloseConnect.Text = "Putuskan Koneksi";
            this.btnCloseConnect.UseVisualStyleBackColor = true;
            this.btnCloseConnect.Click += new System.EventHandler(this.btnCloseConnect_Click);
            // 
            // Uc_TambahKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnCloseConnect);
            this.Controls.Add(this.lblStatusRFID);
            this.Controls.Add(this.cmbPortRFID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBersihkanForm);
            this.Controls.Add(this.btnTambahKaryawan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKodeKaryawan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPilihFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbJabatan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoHp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaLengkap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_TambahKaryawan";
            this.Size = new System.Drawing.Size(850, 603);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbJabatan;
        private System.Windows.Forms.Button btnPilihFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKodeKaryawan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBersihkanForm;
        private System.Windows.Forms.Button btnTambahKaryawan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbPortRFID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Timer tCekPortRFID;
        private System.Windows.Forms.Timer tScanRFID;
        private System.Windows.Forms.Label lblStatusRFID;
        private System.Windows.Forms.Button btnCloseConnect;
    }
}

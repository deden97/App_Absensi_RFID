
namespace App_Absensi_RFID.User_Control
{
    partial class Uc_AbsensiKaryawan
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKodeAbsen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKaryawan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTglAbsen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotAbsen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseConnect = new System.Windows.Forms.Button();
            this.lblStatusRFID = new System.Windows.Forms.Label();
            this.cmbPortRFID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKodeKaryawan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStatusAbsen = new System.Windows.Forms.Label();
            this.tStatusAbsen = new System.Windows.Forms.Timer(this.components);
            this.tScanRFID = new System.Windows.Forms.Timer(this.components);
            this.tPortRFID = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtJabatan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Absensi Karyawan";
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNo,
            this.clmKodeAbsen,
            this.clmKaryawan,
            this.clmTglAbsen});
            this.dgv1.Location = new System.Drawing.Point(8, 28);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(424, 439);
            this.dgv1.TabIndex = 7;
            // 
            // clmNo
            // 
            this.clmNo.HeaderText = "No.";
            this.clmNo.MinimumWidth = 6;
            this.clmNo.Name = "clmNo";
            this.clmNo.ReadOnly = true;
            this.clmNo.Width = 45;
            // 
            // clmKodeAbsen
            // 
            this.clmKodeAbsen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmKodeAbsen.DataPropertyName = "KODE_ABSEN";
            this.clmKodeAbsen.HeaderText = "Kode Absensi";
            this.clmKodeAbsen.MinimumWidth = 6;
            this.clmKodeAbsen.Name = "clmKodeAbsen";
            this.clmKodeAbsen.ReadOnly = true;
            this.clmKodeAbsen.Width = 129;
            // 
            // clmKaryawan
            // 
            this.clmKaryawan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmKaryawan.DataPropertyName = "KARYAWAN";
            this.clmKaryawan.HeaderText = "Karyawan";
            this.clmKaryawan.MinimumWidth = 6;
            this.clmKaryawan.Name = "clmKaryawan";
            this.clmKaryawan.ReadOnly = true;
            this.clmKaryawan.Width = 111;
            // 
            // clmTglAbsen
            // 
            this.clmTglAbsen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmTglAbsen.DataPropertyName = "TANGGAL_ABSEN";
            this.clmTglAbsen.HeaderText = "Tanggal Absen";
            this.clmTglAbsen.MinimumWidth = 6;
            this.clmTglAbsen.Name = "clmTglAbsen";
            this.clmTglAbsen.ReadOnly = true;
            this.clmTglAbsen.Width = 136;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTotAbsen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Location = new System.Drawing.Point(22, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(439, 506);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Absensi Hari Ini";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 110;
            this.label2.Text = ":";
            // 
            // txtTotAbsen
            // 
            this.txtTotAbsen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotAbsen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotAbsen.Enabled = false;
            this.txtTotAbsen.Location = new System.Drawing.Point(362, 472);
            this.txtTotAbsen.Name = "txtTotAbsen";
            this.txtTotAbsen.Size = new System.Drawing.Size(70, 27);
            this.txtTotAbsen.TabIndex = 109;
            this.txtTotAbsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 108;
            this.label3.Text = "Total Absensi";
            // 
            // btnCloseConnect
            // 
            this.btnCloseConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseConnect.Location = new System.Drawing.Point(624, 113);
            this.btnCloseConnect.Name = "btnCloseConnect";
            this.btnCloseConnect.Size = new System.Drawing.Size(159, 32);
            this.btnCloseConnect.TabIndex = 83;
            this.btnCloseConnect.Text = "Putuskan Koneksi";
            this.btnCloseConnect.UseVisualStyleBackColor = true;
            this.btnCloseConnect.Click += new System.EventHandler(this.btnCloseConnect_Click);
            // 
            // lblStatusRFID
            // 
            this.lblStatusRFID.AutoSize = true;
            this.lblStatusRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusRFID.Location = new System.Drawing.Point(620, 148);
            this.lblStatusRFID.Name = "lblStatusRFID";
            this.lblStatusRFID.Size = new System.Drawing.Size(112, 20);
            this.lblStatusRFID.TabIndex = 82;
            this.lblStatusRFID.Text = "Status RFID";
            // 
            // cmbPortRFID
            // 
            this.cmbPortRFID.FormattingEnabled = true;
            this.cmbPortRFID.Location = new System.Drawing.Point(624, 79);
            this.cmbPortRFID.Name = "cmbPortRFID";
            this.cmbPortRFID.Size = new System.Drawing.Size(412, 28);
            this.cmbPortRFID.TabIndex = 81;
            this.cmbPortRFID.Text = "--Hubungkan RFID--";
            this.cmbPortRFID.SelectedIndexChanged += new System.EventHandler(this.cmbPortRFID_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(606, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 80;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(470, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 79;
            this.label13.Text = "Port RFID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 89;
            this.label10.Text = ":";
            // 
            // txtKodeKaryawan
            // 
            this.txtKodeKaryawan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKodeKaryawan.Enabled = false;
            this.txtKodeKaryawan.Location = new System.Drawing.Point(624, 171);
            this.txtKodeKaryawan.Name = "txtKodeKaryawan";
            this.txtKodeKaryawan.Size = new System.Drawing.Size(412, 27);
            this.txtKodeKaryawan.TabIndex = 88;
            this.txtKodeKaryawan.TextChanged += new System.EventHandler(this.txtKodeKaryawan_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 87;
            this.label11.Text = "Kode Karyawan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = ":";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNamaLengkap.Enabled = false;
            this.txtNamaLengkap.Location = new System.Drawing.Point(624, 204);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(412, 27);
            this.txtNamaLengkap.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 84;
            this.label5.Text = "Nama Lengkap";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::App_Absensi_RFID.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(624, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(606, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 20);
            this.label14.TabIndex = 91;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(470, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 90;
            this.label15.Text = "Foto";
            // 
            // lblStatusAbsen
            // 
            this.lblStatusAbsen.AutoSize = true;
            this.lblStatusAbsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusAbsen.Location = new System.Drawing.Point(620, 479);
            this.lblStatusAbsen.Name = "lblStatusAbsen";
            this.lblStatusAbsen.Size = new System.Drawing.Size(121, 20);
            this.lblStatusAbsen.TabIndex = 93;
            this.lblStatusAbsen.Text = "Status Absen";
            // 
            // tStatusAbsen
            // 
            this.tStatusAbsen.Enabled = true;
            this.tStatusAbsen.Interval = 500;
            // 
            // tScanRFID
            // 
            this.tScanRFID.Interval = 500;
            this.tScanRFID.Tick += new System.EventHandler(this.tScanRFID_Tick);
            // 
            // tPortRFID
            // 
            this.tPortRFID.Enabled = true;
            this.tPortRFID.Interval = 500;
            this.tPortRFID.Tick += new System.EventHandler(this.tPortRFID_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = ":";
            // 
            // txtJabatan
            // 
            this.txtJabatan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJabatan.Enabled = false;
            this.txtJabatan.Location = new System.Drawing.Point(624, 237);
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.Size = new System.Drawing.Size(412, 27);
            this.txtJabatan.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 94;
            this.label7.Text = "Jabatan";
            // 
            // Uc_AbsensiKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtJabatan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStatusAbsen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKodeKaryawan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamaLengkap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCloseConnect);
            this.Controls.Add(this.lblStatusRFID);
            this.Controls.Add(this.cmbPortRFID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_AbsensiKaryawan";
            this.Size = new System.Drawing.Size(1091, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotAbsen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeAbsen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKaryawan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTglAbsen;
        private System.Windows.Forms.Button btnCloseConnect;
        private System.Windows.Forms.Label lblStatusRFID;
        private System.Windows.Forms.ComboBox cmbPortRFID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKodeKaryawan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblStatusAbsen;
        private System.Windows.Forms.Timer tStatusAbsen;
        private System.Windows.Forms.Timer tScanRFID;
        private System.Windows.Forms.Timer tPortRFID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJabatan;
        private System.Windows.Forms.Label label7;
    }
}

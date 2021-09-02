
namespace App_Absensi_RFID.User_Control
{
    partial class Uc_LaporanAbsensi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtJmlData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKodeAbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTglAbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKodeKry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNmKry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKdJbt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJbt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHarian = new System.Windows.Forms.Button();
            this.btnBulanan = new System.Windows.Forms.Button();
            this.btnTahunan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTgl = new System.Windows.Forms.ComboBox();
            this.cmbBln = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbThn = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOke = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBuatLap = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Laporan Absensi Karyawan";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtJmlData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(69, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 384);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtJmlData
            // 
            this.txtJmlData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJmlData.Enabled = false;
            this.txtJmlData.Location = new System.Drawing.Point(718, 351);
            this.txtJmlData.Name = "txtJmlData";
            this.txtJmlData.Size = new System.Drawing.Size(100, 27);
            this.txtJmlData.TabIndex = 3;
            this.txtJmlData.Text = "0";
            this.txtJmlData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNo,
            this.clmKodeAbs,
            this.clmTglAbs,
            this.clmKodeKry,
            this.clmNmKry,
            this.clmKdJbt,
            this.clmJbt});
            this.dgv.Location = new System.Drawing.Point(6, 26);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(812, 319);
            this.dgv.TabIndex = 0;
            // 
            // clmNo
            // 
            this.clmNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmNo.HeaderText = "No.";
            this.clmNo.MinimumWidth = 6;
            this.clmNo.Name = "clmNo";
            this.clmNo.ReadOnly = true;
            this.clmNo.Width = 63;
            // 
            // clmKodeAbs
            // 
            this.clmKodeAbs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmKodeAbs.DataPropertyName = "KODE_ABSEN";
            this.clmKodeAbs.HeaderText = "Kode Absen";
            this.clmKodeAbs.MinimumWidth = 6;
            this.clmKodeAbs.Name = "clmKodeAbs";
            this.clmKodeAbs.ReadOnly = true;
            this.clmKodeAbs.Width = 118;
            // 
            // clmTglAbs
            // 
            this.clmTglAbs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmTglAbs.DataPropertyName = "TANGGAL_ABSEN";
            this.clmTglAbs.HeaderText = "Tanggal Absen";
            this.clmTglAbs.MinimumWidth = 6;
            this.clmTglAbs.Name = "clmTglAbs";
            this.clmTglAbs.ReadOnly = true;
            this.clmTglAbs.Width = 136;
            // 
            // clmKodeKry
            // 
            this.clmKodeKry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmKodeKry.DataPropertyName = "KODE_KARYAWAN";
            this.clmKodeKry.HeaderText = "Kode Karyawan";
            this.clmKodeKry.MinimumWidth = 6;
            this.clmKodeKry.Name = "clmKodeKry";
            this.clmKodeKry.ReadOnly = true;
            this.clmKodeKry.Width = 141;
            // 
            // clmNmKry
            // 
            this.clmNmKry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmNmKry.DataPropertyName = "NAMA";
            this.clmNmKry.HeaderText = "Nama Karyawan";
            this.clmNmKry.MinimumWidth = 6;
            this.clmNmKry.Name = "clmNmKry";
            this.clmNmKry.ReadOnly = true;
            this.clmNmKry.Width = 146;
            // 
            // clmKdJbt
            // 
            this.clmKdJbt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmKdJbt.DataPropertyName = "KODE_JABATAN";
            this.clmKdJbt.HeaderText = "Kode Jabatan";
            this.clmKdJbt.MinimumWidth = 6;
            this.clmKdJbt.Name = "clmKdJbt";
            this.clmKdJbt.ReadOnly = true;
            this.clmKdJbt.Width = 128;
            // 
            // clmJbt
            // 
            this.clmJbt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmJbt.DataPropertyName = "NAMA_JABATAN";
            this.clmJbt.HeaderText = "Jabatan";
            this.clmJbt.MinimumWidth = 6;
            this.clmJbt.Name = "clmJbt";
            this.clmJbt.ReadOnly = true;
            this.clmJbt.Width = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Laporan Per-";
            // 
            // btnHarian
            // 
            this.btnHarian.BackColor = System.Drawing.Color.LightCoral;
            this.btnHarian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarian.Location = new System.Drawing.Point(224, 444);
            this.btnHarian.Name = "btnHarian";
            this.btnHarian.Size = new System.Drawing.Size(84, 25);
            this.btnHarian.TabIndex = 13;
            this.btnHarian.Text = "Harian";
            this.btnHarian.UseVisualStyleBackColor = false;
            // 
            // btnBulanan
            // 
            this.btnBulanan.BackColor = System.Drawing.Color.LightCoral;
            this.btnBulanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBulanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulanan.Location = new System.Drawing.Point(335, 444);
            this.btnBulanan.Name = "btnBulanan";
            this.btnBulanan.Size = new System.Drawing.Size(84, 25);
            this.btnBulanan.TabIndex = 14;
            this.btnBulanan.Text = "Bulanan";
            this.btnBulanan.UseVisualStyleBackColor = false;
            // 
            // btnTahunan
            // 
            this.btnTahunan.BackColor = System.Drawing.Color.LightCoral;
            this.btnTahunan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTahunan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTahunan.Location = new System.Drawing.Point(446, 444);
            this.btnTahunan.Name = "btnTahunan";
            this.btnTahunan.Size = new System.Drawing.Size(84, 25);
            this.btnTahunan.TabIndex = 15;
            this.btnTahunan.Text = "Tahunan";
            this.btnTahunan.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tanggal";
            // 
            // cmbTgl
            // 
            this.cmbTgl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTgl.FormattingEnabled = true;
            this.cmbTgl.Location = new System.Drawing.Point(224, 476);
            this.cmbTgl.Name = "cmbTgl";
            this.cmbTgl.Size = new System.Drawing.Size(84, 28);
            this.cmbTgl.TabIndex = 17;
            this.cmbTgl.Text = "--Tgl--";
            // 
            // cmbBln
            // 
            this.cmbBln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBln.FormattingEnabled = true;
            this.cmbBln.Location = new System.Drawing.Point(335, 476);
            this.cmbBln.Name = "cmbBln";
            this.cmbBln.Size = new System.Drawing.Size(84, 28);
            this.cmbBln.TabIndex = 18;
            this.cmbBln.Text = "--Bln--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "-";
            // 
            // cmbThn
            // 
            this.cmbThn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbThn.FormattingEnabled = true;
            this.cmbThn.Location = new System.Drawing.Point(446, 476);
            this.cmbThn.Name = "cmbThn";
            this.cmbThn.Size = new System.Drawing.Size(84, 28);
            this.cmbThn.TabIndex = 21;
            this.cmbThn.Text = "--Thn--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(314, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "/";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(425, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "/";
            // 
            // btnOke
            // 
            this.btnOke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOke.Enabled = false;
            this.btnOke.Location = new System.Drawing.Point(224, 520);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(84, 32);
            this.btnOke.TabIndex = 25;
            this.btnOke.Text = "Oke";
            this.btnOke.UseVisualStyleBackColor = true;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBuatLap
            // 
            this.btnBuatLap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuatLap.Enabled = false;
            this.btnBuatLap.Location = new System.Drawing.Point(314, 520);
            this.btnBuatLap.Name = "btnBuatLap";
            this.btnBuatLap.Size = new System.Drawing.Size(126, 32);
            this.btnBuatLap.TabIndex = 26;
            this.btnBuatLap.Text = "Buat Laporan";
            this.btnBuatLap.UseVisualStyleBackColor = true;
            this.btnBuatLap.Click += new System.EventHandler(this.btnBuatLap_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearForm.Enabled = false;
            this.btnClearForm.Location = new System.Drawing.Point(446, 520);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(159, 32);
            this.btnClearForm.TabIndex = 27;
            this.btnClearForm.Text = "Bersihkan Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // Uc_LaporanAbsensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnBuatLap);
            this.Controls.Add(this.btnOke);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbThn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBln);
            this.Controls.Add(this.cmbTgl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTahunan);
            this.Controls.Add(this.btnBulanan);
            this.Controls.Add(this.btnHarian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_LaporanAbsensi";
            this.Size = new System.Drawing.Size(957, 642);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJmlData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHarian;
        private System.Windows.Forms.Button btnBulanan;
        private System.Windows.Forms.Button btnTahunan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTgl;
        private System.Windows.Forms.ComboBox cmbBln;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbThn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOke;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeAbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTglAbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKodeKry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNmKry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKdJbt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJbt;
        private System.Windows.Forms.Button btnBuatLap;
        private System.Windows.Forms.Button btnClearForm;
    }
}

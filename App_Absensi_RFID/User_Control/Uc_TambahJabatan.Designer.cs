
namespace App_Absensi_RFID.User_Control
{
    partial class Uc_TambahJabatan
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
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnTambahJabatan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKodeJabatan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNamaJabatan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKodeJabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNamaJabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotJabatan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tambah Jabatan Karyawan";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearForm.Location = new System.Drawing.Point(763, 164);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(154, 32);
            this.btnClearForm.TabIndex = 3;
            this.btnClearForm.Text = "Bersihkan Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnTambahJabatan
            // 
            this.btnTambahJabatan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahJabatan.Enabled = false;
            this.btnTambahJabatan.Location = new System.Drawing.Point(604, 164);
            this.btnTambahJabatan.Name = "btnTambahJabatan";
            this.btnTambahJabatan.Size = new System.Drawing.Size(153, 32);
            this.btnTambahJabatan.TabIndex = 2;
            this.btnTambahJabatan.Text = "Tambah Jabatan";
            this.btnTambahJabatan.UseVisualStyleBackColor = true;
            this.btnTambahJabatan.Click += new System.EventHandler(this.btnTambahJabatan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(584, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 97;
            this.label10.Text = ":";
            // 
            // txtKodeJabatan
            // 
            this.txtKodeJabatan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKodeJabatan.Location = new System.Drawing.Point(604, 89);
            this.txtKodeJabatan.Name = "txtKodeJabatan";
            this.txtKodeJabatan.Size = new System.Drawing.Size(380, 27);
            this.txtKodeJabatan.TabIndex = 0;
            this.txtKodeJabatan.TextChanged += new System.EventHandler(this.txtKodeJabatan_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 95;
            this.label11.Text = "Kode Jabatan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(584, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 94;
            this.label12.Text = ":";
            // 
            // txtNamaJabatan
            // 
            this.txtNamaJabatan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNamaJabatan.Enabled = false;
            this.txtNamaJabatan.Location = new System.Drawing.Point(604, 122);
            this.txtNamaJabatan.Name = "txtNamaJabatan";
            this.txtNamaJabatan.Size = new System.Drawing.Size(380, 27);
            this.txtNamaJabatan.TabIndex = 1;
            this.txtNamaJabatan.TextChanged += new System.EventHandler(this.txtNamaJabatan_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(451, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 92;
            this.label13.Text = "Nama Jabatan";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNo,
            this.dgvKodeJabatan,
            this.dgvNamaJabatan});
            this.dgv.Location = new System.Drawing.Point(6, 26);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(384, 203);
            this.dgv.TabIndex = 103;
            // 
            // dgvNo
            // 
            this.dgvNo.HeaderText = "No.";
            this.dgvNo.MinimumWidth = 6;
            this.dgvNo.Name = "dgvNo";
            this.dgvNo.ReadOnly = true;
            this.dgvNo.Width = 50;
            // 
            // dgvKodeJabatan
            // 
            this.dgvKodeJabatan.DataPropertyName = "KODE_JABATAN";
            this.dgvKodeJabatan.HeaderText = "Kode jabatan";
            this.dgvKodeJabatan.MinimumWidth = 6;
            this.dgvKodeJabatan.Name = "dgvKodeJabatan";
            this.dgvKodeJabatan.ReadOnly = true;
            this.dgvKodeJabatan.Width = 125;
            // 
            // dgvNamaJabatan
            // 
            this.dgvNamaJabatan.DataPropertyName = "NAMA_JABATAN";
            this.dgvNamaJabatan.HeaderText = "Nama Jabatan";
            this.dgvNamaJabatan.MinimumWidth = 6;
            this.dgvNamaJabatan.Name = "dgvNamaJabatan";
            this.dgvNamaJabatan.ReadOnly = true;
            this.dgvNamaJabatan.Width = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Controls.Add(this.txtTotJabatan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(49, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 268);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jabatan Karyawan";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = ":";
            // 
            // txtTotJabatan
            // 
            this.txtTotJabatan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotJabatan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotJabatan.Enabled = false;
            this.txtTotJabatan.Location = new System.Drawing.Point(320, 235);
            this.txtTotJabatan.Name = "txtTotJabatan";
            this.txtTotJabatan.Size = new System.Drawing.Size(70, 27);
            this.txtTotJabatan.TabIndex = 106;
            this.txtTotJabatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Total Jabatan";
            // 
            // Uc_TambahJabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnTambahJabatan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKodeJabatan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNamaJabatan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_TambahJabatan";
            this.Size = new System.Drawing.Size(1031, 389);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnTambahJabatan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKodeJabatan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNamaJabatan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotJabatan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKodeJabatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNamaJabatan;
    }
}

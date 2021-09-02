
namespace App_Absensi_RFID.User_Control
{
    partial class Uc_TambahAkunAdmin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbLaki2 = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKonfirPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.ckbTampilkanPassword = new System.Windows.Forms.CheckBox();
            this.btnPilihFoto = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buat Akun Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Lengkap";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNamaLengkap.Location = new System.Drawing.Point(228, 58);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(421, 27);
            this.txtNamaLengkap.TabIndex = 6;
            this.txtNamaLengkap.TextChanged += new System.EventHandler(this.txtNamaLengkap_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jenis Kelamin";
            // 
            // rbLaki2
            // 
            this.rbLaki2.AutoSize = true;
            this.rbLaki2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbLaki2.Enabled = false;
            this.rbLaki2.Location = new System.Drawing.Point(229, 91);
            this.rbLaki2.Name = "rbLaki2";
            this.rbLaki2.Size = new System.Drawing.Size(108, 24);
            this.rbLaki2.TabIndex = 11;
            this.rbLaki2.TabStop = true;
            this.rbLaki2.Text = "Laki - Laki";
            this.rbLaki2.UseVisualStyleBackColor = false;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbPerempuan.Enabled = false;
            this.rbPerempuan.Location = new System.Drawing.Point(343, 91);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(115, 24);
            this.rbPerempuan.TabIndex = 12;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = ":";
            // 
            // txtNoHp
            // 
            this.txtNoHp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNoHp.Enabled = false;
            this.txtNoHp.Location = new System.Drawing.Point(229, 121);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(421, 27);
            this.txtNoHp.TabIndex = 14;
            this.txtNoHp.TextChanged += new System.EventHandler(this.txtNoHp_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "No. HP.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = ":";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(229, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(421, 27);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = ":";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(229, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(421, 27);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = ":";
            // 
            // txtKonfirPassword
            // 
            this.txtKonfirPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKonfirPassword.Enabled = false;
            this.txtKonfirPassword.Location = new System.Drawing.Point(229, 220);
            this.txtKonfirPassword.Name = "txtKonfirPassword";
            this.txtKonfirPassword.Size = new System.Drawing.Size(421, 27);
            this.txtKonfirPassword.TabIndex = 23;
            this.txtKonfirPassword.UseSystemPasswordChar = true;
            this.txtKonfirPassword.TextChanged += new System.EventHandler(this.txtKonfirPassword_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Konfirmasi Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(208, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Foto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::App_Absensi_RFID.Properties.Resources.profile_user;
            this.pictureBox1.Location = new System.Drawing.Point(228, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(227, 474);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 32);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.Location = new System.Drawing.Point(333, 474);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 32);
            this.btnBatal.TabIndex = 32;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // ckbTampilkanPassword
            // 
            this.ckbTampilkanPassword.AutoSize = true;
            this.ckbTampilkanPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbTampilkanPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTampilkanPassword.Location = new System.Drawing.Point(228, 253);
            this.ckbTampilkanPassword.Name = "ckbTampilkanPassword";
            this.ckbTampilkanPassword.Size = new System.Drawing.Size(160, 21);
            this.ckbTampilkanPassword.TabIndex = 33;
            this.ckbTampilkanPassword.Text = "Tampilkan Password";
            this.ckbTampilkanPassword.UseVisualStyleBackColor = false;
            // 
            // btnPilihFoto
            // 
            this.btnPilihFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilihFoto.Enabled = false;
            this.btnPilihFoto.Location = new System.Drawing.Point(378, 280);
            this.btnPilihFoto.Name = "btnPilihFoto";
            this.btnPilihFoto.Size = new System.Drawing.Size(118, 32);
            this.btnPilihFoto.TabIndex = 34;
            this.btnPilihFoto.Text = "Pilih Foto";
            this.btnPilihFoto.UseVisualStyleBackColor = true;
            this.btnPilihFoto.Click += new System.EventHandler(this.btnPilihFoto_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ofd
            // 
            this.ofd.Title = "Pilih Foto";
            // 
            // Uc_TambahAkunAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnPilihFoto);
            this.Controls.Add(this.ckbTampilkanPassword);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtKonfirPassword);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsername);
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
            this.Name = "Uc_TambahAkunAdmin";
            this.Size = new System.Drawing.Size(841, 527);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbLaki2;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKonfirPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.CheckBox ckbTampilkanPassword;
        private System.Windows.Forms.Button btnPilihFoto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

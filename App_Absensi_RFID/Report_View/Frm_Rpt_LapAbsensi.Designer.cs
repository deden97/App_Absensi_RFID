
namespace App_Absensi_RFID.Report_View
{
    partial class Frm_Rpt_LapAbsensi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LAPORAN_ABSENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_LapAbsensi = new App_Absensi_RFID.DataSet.DataSet_LapAbsensi();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lAPORANABSENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAPORAN_ABSEN_TA = new App_Absensi_RFID.DataSet.DataSet_LapAbsensiTableAdapters.LAPORAN_ABSEN_TA();
            ((System.ComponentModel.ISupportInitialize)(this.LAPORAN_ABSENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_LapAbsensi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAPORANABSENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LAPORAN_ABSENBindingSource
            // 
            this.LAPORAN_ABSENBindingSource.DataMember = "LAPORAN_ABSEN";
            this.LAPORAN_ABSENBindingSource.DataSource = this.dataSet_LapAbsensi;
            // 
            // dataSet_LapAbsensi
            // 
            this.dataSet_LapAbsensi.DataSetName = "DataSet_LapAbsensi";
            this.dataSet_LapAbsensi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DS_LapAbsen";
            reportDataSource2.Value = this.LAPORAN_ABSENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App_Absensi_RFID.Report_Design.Report_LapAbsensi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // lAPORANABSENBindingSource
            // 
            this.lAPORANABSENBindingSource.DataMember = "LAPORAN_ABSEN";
            this.lAPORANABSENBindingSource.DataSource = this.dataSet_LapAbsensi;
            // 
            // lAPORAN_ABSEN_TA
            // 
            this.lAPORAN_ABSEN_TA.ClearBeforeFill = true;
            // 
            // Frm_Rpt_LapAbsensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rpt_LapAbsensi";
            this.ShowIcon = false;
            this.Text = "App_Absensi_RFID | Laporan Absensi Karyawan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Rpt_LapAbsensi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LAPORAN_ABSENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_LapAbsensi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAPORANABSENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lAPORANABSENBindingSource;
        private DataSet.DataSet_LapAbsensi dataSet_LapAbsensi;
        private DataSet.DataSet_LapAbsensiTableAdapters.LAPORAN_ABSEN_TA lAPORAN_ABSEN_TA;
        private System.Windows.Forms.BindingSource LAPORAN_ABSENBindingSource;
    }
}
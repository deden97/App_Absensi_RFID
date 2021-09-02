using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace App_Absensi_RFID.Report_View
{
    public partial class Frm_Rpt_LapAbsensi : Form
    {
        public string Tgl { get; set; }
        public string LapPer { get; set; }
        public string Admin { get; set; }
        public string TotKaryawan { get; set; }

        public Frm_Rpt_LapAbsensi() => InitializeComponent();

        private void Frm_Rpt_LapAbsensi_Load(object sender, EventArgs e)
        {
            this.lAPORAN_ABSEN_TA.Fill(this.dataSet_LapAbsensi.LAPORAN_ABSEN, this.Tgl);
            ReportParameter[] param = new ReportParameter[]
            {
                new ReportParameter("lapPer", this.LapPer),
                new ReportParameter("admin", this.Admin),
                new ReportParameter("totKry", this.TotKaryawan)
            };
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Absensi_RFID.Frm
{
    public partial class Frm_ScanRFID : Form
    {
        public Frm_ScanRFID()
        {
            InitializeComponent();
            this.btnBatal.Click += delegate { this.Close(); };
        }
    }
}

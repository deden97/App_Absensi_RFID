//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Absensi_RFID.User_Control
{
    public partial class Uc_Dashboard : UserControl
    {
        private static Uc_Dashboard instance;
        public static Uc_Dashboard Instance { get { return (instance == null) ? instance = new Uc_Dashboard() : instance; } }

        public Uc_Dashboard() => InitializeComponent();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace App_Absensi_RFID.Config
{
    public static class ConnectRFID
    {
        public static SerialPort rfid = new SerialPort();

        public static string[] GetPort { get { return SerialPort.GetPortNames(); } }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace USBList.Device
{
    class USBDeviceImpl : USBDevice
    {
        public string Name { get; set; }
        public char Letter { get; set; }
        public double FreeMemory { get; set; }
        public double UsedMemory { get; set; }
        public double TotalMemory { get; set; }
        public void Eject()
        {
            var сmd = new Process();
            сmd.StartInfo.UseShellExecute = false;
            сmd.StartInfo.RedirectStandardOutput = true;
            сmd.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
            сmd.StartInfo.FileName = Path.Combine(System.Environment.SystemDirectory + "\\rmdrive");
            сmd.StartInfo.Arguments = Letter.ToString();
            сmd.StartInfo.CreateNoWindow = true;
            сmd.Start();
        }
    }
}

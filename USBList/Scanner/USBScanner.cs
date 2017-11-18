using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using USBList.Device;

namespace USBList.Scanner
{
    sealed class USBScanner
    {
        private static USBScanner _instance;

        public static USBScanner GetInstance()
        {
            if (_instance == null)
            {
                _instance = new USBScanner();
            }
            return _instance;
        }

        public List<USBDevice> GetUSBDevices()
        {
            //TODO
            return null;
        }


        /// <summary>
        /// This fuction gets the list of USB devices
        /// </summary>
        /// <returns></returns>
        private List<USBDevice> getUSBList()
        {
            var drives = System.IO.DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == System.IO.DriveType.Removable).ToList();
            var res = new List<USBDevice>();
            foreach (var d in drives)
            {
                var t = new USBDeviceImpl();
                t.TotalMemory = d.TotalSize;
                t.FreeMemory = d.TotalFreeSpace;
                t.UsedMemory = d.TotalSize - d.TotalFreeSpace;
                t.Name = d.VolumeLabel;
                t.Letter = d.RootDirectory.ToString()[0];
            }
            return res;
        }
    }
}

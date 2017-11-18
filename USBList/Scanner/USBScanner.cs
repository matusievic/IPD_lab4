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


    }
}

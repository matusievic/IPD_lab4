using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using USBList.Scanner;
using USBList.Device;

namespace USBList.Dispatcher
{
    sealed class USBDispatcher
    {
        private static USBDispatcher _instance;
        public static USBDispatcher GetInstance()
        {
            if (_instance == null)
            {
                _instance = new USBDispatcher();
            }
            return _instance;
        }

        public List<USBDevice> USBDevices { get; private set; }
        public List<USBDevice> UpdateList()
        {
            USBDevices = USBScanner.GetInstance().GetUSBDevices();
            return USBDevices;
        }
    }
}

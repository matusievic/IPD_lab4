using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using USBList.Scanner;
using USBList.Device;

namespace USBList.Dispatcher
{
    class USBDispatcher
    {
        public List<USBDevice> USBDevices { get; private set; }
        public List<USBDevice> UpdateList()
        {
            USBDevices = new USBScanner().GetUSBDevices();
            return USBDevices;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace USBList.Device
{
    interface USBDevice
    {
        string Name { get; }
        char Letter { get; }
        double TotalMemory { get; }
        double UsedMemory { get; }
        double FreeMemory { get; }
        void eject();
    }
}

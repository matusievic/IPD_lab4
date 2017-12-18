using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using USBList.Device;
using System.IO;

namespace USBList.Scanner
{
    class USBScanner
    {
        public List<USBDevice> GetUSBDevices()
        {
            var mtpDevices = new WinUSB.MTPClass().Devices();
            var mtpList = new List<MTPDeviceImpl>();
            foreach (var mtp in mtpDevices)
            {
                var temp = new MTPDeviceImpl();
                temp.Name = mtp.Name;
                temp.Letter = '\0';
                temp.FreeMemory = mtp.FreeMemory;
                temp.TotalMemory = mtp.TotalMemory;
                temp.UsedMemory = temp.TotalMemory - temp.FreeMemory;
                mtpList.Add(temp);
            }
            var list = new List<USBDevice>();
            var usbList = getUSBList();

            for (var i = 0; i < usbList.Count; i++)
            {
                for (var j = 0; j < mtpList.Count; j++)
                {
                    if (usbList[i].FreeMemory == mtpList[i].FreeMemory && usbList[i].TotalMemory == mtpList[i].TotalMemory && usbList[i].UsedMemory == mtpList[i].UsedMemory)
                    {
                        mtpList.Remove(mtpList[j]);
                        j--;
                    }
                }
            }

            list.AddRange(usbList);
            list.AddRange(mtpList);

            return list;
        }

        /// <summary>
        /// This fuction gets the list of USB devices
        /// </summary>
        /// <returns>a list</returns>
        private List<USBDevice> getUSBList()
        {
            var drives = System.IO.DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == System.IO.DriveType.Removable).ToList();
            var list = new List<USBDevice>();
            foreach (var drive in drives)
            {
                var d = new USBDeviceImpl();
                try
                {
                    d.TotalMemory = drive.TotalSize;
                    d.FreeMemory = drive.TotalFreeSpace;
                    d.UsedMemory = drive.TotalSize - drive.TotalFreeSpace;
                    d.Name = drive.VolumeLabel;
                    d.Letter = drive.RootDirectory.ToString()[0];
                }
                catch (UnauthorizedAccessException e)
                {
                    continue;
                }
                list.Add(d);
            }
            return list;
        }
    }
}
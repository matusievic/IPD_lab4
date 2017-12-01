using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using USBList.Dispatcher;

namespace USBList
{
    public partial class UBSListForm : Form
    {
        private Updater _updaterThread;
        public UBSListForm()
        {
            InitializeComponent();
            USBListTable.AllowUserToAddRows = false;
            USBListTable.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            USBListTable.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            _updaterThread = new Updater(this);
            _updaterThread.IsInterrupted = false;
        }


        public void UpdateFormData()
        {
            var toGBcoeff = Math.Pow(1024, 3);
            var currentRow = USBListTable.CurrentRow;
            var list = new USBDispatcher().UpdateList();
            USBListTable.Rows.Clear();

            foreach (var usb in list)
            {
                USBListTable.Rows.Add(usb.Name, usb.Letter, (usb.FreeMemory / toGBcoeff).ToString("0.00 GB"), (usb.UsedMemory / toGBcoeff).ToString("0.00 GB"), (usb.TotalMemory / toGBcoeff).ToString("0.00 GB"), null);
            }
        }

        private void UBSListForm_Closed(object sender, FormClosedEventArgs e)
        {
            _updaterThread.IsInterrupted = true;
        }

        private void USBListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5) { return; }
            var list = new USBDispatcher().UpdateList();
            list[e.RowIndex].Eject();
        }
    }
}

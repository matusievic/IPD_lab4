using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using USBList.Dispatcher;
using System.Windows.Forms;

namespace USBList
{
    class Updater
    {
        private Thread _updaterThread;
        public bool IsInterrupted { get; set; }
        private UBSListForm _form;

        public Updater(UBSListForm form)
        {
            _form = form;
            _updaterThread = new Thread(this.ThreadFucntion);
            IsInterrupted = false;
            _updaterThread.Start();
        }


        private void ThreadFucntion()
        {
            const int ONE_SECOND = 1000;
            while (!IsInterrupted)
            {
                Thread.Sleep(ONE_SECOND);
                try
                { _form.Invoke((MethodInvoker)delegate { _form.UpdateFormData(); }); }
                catch
                { break; }
            }
        }
    }
}

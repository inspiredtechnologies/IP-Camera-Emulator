using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace IpCameraEmulatorStd
{
  static class Program
  {
    private static string appGuid = "01CD8ADA-E692-4971-98F9-B8E709037768";

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
      {
        // Allow running one and only one instance
        if (!mutex.WaitOne(0, false))
        {
          MessageBox.Show("Application already running", "IP Camera Emulator", 
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormMain());
      }
    }
  }
}

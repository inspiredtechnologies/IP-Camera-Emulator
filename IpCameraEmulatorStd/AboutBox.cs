using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emulator;
using SystemMetrics;

namespace IpCameraEmulatorStd
{
  partial class AboutBox : Form
  {
    public AboutBox()
    {
      try
      {
        InitializeComponent();
        this.Text = String.Format("About {0}", AssemblyTitle);
        this.labelProductName.Text = AssemblyProduct;
        this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
        this.labelCopyright.Text = AssemblyCopyright;
        this.labelCompanyName.Text = AssemblyCompany;

        EmulatorEngine testEngine = new EmulatorEngine("test", string.Empty, 554, true);
        this.labelLibVersion.Text = "VLC Library Version: " + testEngine.GetVlcLibraryVersion();
        testEngine.Dispose();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    #region Assembly Attribute Accessors

    public string AssemblyTitle
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        if (attributes.Length > 0)
        {
          AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
          if (titleAttribute.Title != "")
          {
            return titleAttribute.Title;
          }
        }
        return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
      }
    }

    public string AssemblyVersion
    {
      get
      {
        return Assembly.GetExecutingAssembly().GetName().Version.ToString();
      }
    }

    public string AssemblyDescription
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyDescriptionAttribute)attributes[0]).Description;
      }
    }

    public string AssemblyProduct
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyProductAttribute)attributes[0]).Product;
      }
    }

    public string AssemblyCopyright
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
      }
    }

    public string AssemblyCompany
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyCompanyAttribute)attributes[0]).Company;
      }
    }
    #endregion

    private void AboutBox_Load(object sender, EventArgs e)
    {
      this.Text = "About IP Camera Emulator";
    }

    private void btnCopyToClipboard_Click(object sender, EventArgs e)
    {
      try
      {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.labelProductName.Text + Environment.NewLine);
        sb.Append(this.labelVersion.Text + Environment.NewLine);
        sb.Append(this.labelCompanyName.Text + Environment.NewLine);
        sb.Append(this.labelLibVersion.Text + Environment.NewLine);
        sb.Append("Emulator library version: " + typeof(EmulatorChannel).Assembly.GetName().Version.ToString() + Environment.NewLine);
        sb.Append("SystemMetrics library version: " + typeof(OsMetrics).Assembly.GetName().Version.ToString() + Environment.NewLine);
        sb.Append("OS: " + OsMetrics.GetOSVersion() + " (" + 
          (Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit") + ")" + Environment.NewLine);
        sb.Append("DotNet Framework: " + Environment.Version + Environment.NewLine);
        sb.Append("System Resources: CPU - " + Environment.ProcessorCount.ToString() + 
          "-core, Memory: " + (OsMetrics.GetInstalledPhysicalMemory() / 1024).ToString("0") + " MB" + Environment.NewLine);
        Clipboard.Clear();
        Clipboard.SetText(sb.ToString());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }
  }
}

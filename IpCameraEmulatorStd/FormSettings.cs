using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpCameraEmulatorStd
{
  public partial class FormSettings : Form
  {
    SystemConfiguration _Config = null;

    public FormSettings(SystemConfiguration config)
    {
      InitializeComponent();
      _Config = config;
    }

    private void FormSettings_Load(object sender, EventArgs e)
    {
      chkShowSystemResourceUsage.Checked = (_Config != null) ? _Config.ShowSystemResourceUsage : false;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.Close();
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      _Config.ShowSystemResourceUsage = chkShowSystemResourceUsage.Checked;
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.Close();
    }
  }
}

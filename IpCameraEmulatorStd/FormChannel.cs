using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emulator;

namespace IpCameraEmulatorStd
{
  public partial class FormChannel : Form
  {
    private const string urlPrefix = "rtsp://<this machine's IP addr>:";

    public bool _EditMode;
    public Collection<EmulatorChannel> CurrentChannels { get; set; }
    public Collection<EmulatorChannel> AllChannels { get; set; }

    public void SetEditMode(bool editMode, EmulatorChannel currentChannel)
    {
      _EditMode = editMode;
      this.Text = _EditMode ? "Edit Channel" : "Add Channel";
      btnAdd.Text = _EditMode ? "Update" : "Add";
      lblBatchAddition.Visible = updChannelQty.Visible = !_EditMode;
      lblChannelIndex.Visible = txtChannelIndex.Visible = _EditMode;

      if (_EditMode)
      {
        if (CurrentChannels == null)
          CurrentChannels = new Collection<EmulatorChannel>();
        else
          CurrentChannels.Clear();
        CurrentChannels.Add(currentChannel);

        updChannelQty.Value = 1;
        updChannelQty.Enabled = false;
        txtChannelIndex.Text = currentChannel.Id.ToString();
        txtChannelIndex.Enabled = false;
        txtChannelName.Text = currentChannel.Name;
        txtVideoFilePath.Text = currentChannel.MediaPath;
        updRtspPort.Value = currentChannel.RtspPort;
        chkChannelEnabled.Checked = currentChannel.Enabled;
      }
    }

    public FormChannel()
    {
      InitializeComponent();
      _EditMode = false;
    }

    private void FormChannel_Load(object sender, EventArgs e)
    {
      UpdatePortTooltip();
    }

    private void FormChannel_Shown(object sender, EventArgs e)
    {
      if (!_EditMode)
      {
        txtChannelName.Focus();
      }
    }
    
    private void btnAdd_Click(object sender, EventArgs e)
    {
      string messageTitle = _EditMode ? "Modify Channel" : "Add Channel";

      if (!File.Exists(txtVideoFilePath.Text))
      {
        txtVideoFilePath.Focus();
        MessageBox.Show("Invalid Video File", messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      if (CheckForDuplicatedRtspPort())
      {
        updRtspPort.Focus();
        MessageBox.Show("RTSP Port " + updRtspPort.Value.ToString() + " has been assigned." + Environment.NewLine,
          messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (!_EditMode)
      {
        if (CurrentChannels == null)
        {
          CurrentChannels = new Collection<EmulatorChannel>();
        }
        int rtspPort = (int)updRtspPort.Value;
        for (int i = 0; i < updChannelQty.Value; i++)
        {
          CurrentChannels.Add(new EmulatorChannel(0, txtChannelName.Text, txtVideoFilePath.Text,
            rtspPort++, chkChannelEnabled.Checked));
        }
      }
      else
      {
        if (CurrentChannels != null && CurrentChannels.Count > 0)
        {
          CurrentChannels[0].Name = txtChannelName.Text;
          CurrentChannels[0].MediaPath = txtVideoFilePath.Text;
          CurrentChannels[0].RtspPort = (int)updRtspPort.Value;
          CurrentChannels[0].Enabled = chkChannelEnabled.Checked;
        }
      }
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.Close();
    }

    private bool CheckForDuplicatedRtspPort()
    {
      if (AllChannels != null)
      {
        foreach (EmulatorChannel channel in AllChannels)
        {
          if (_EditMode)
          {
            if (CurrentChannels != null && CurrentChannels.Count > 0)
            {
              if (channel.Id != CurrentChannels[0].Id)
              {
                if (channel.RtspPort == CurrentChannels[0].RtspPort)
                  return true;
              }
            }
          }
          else
          {
            if (channel.RtspPort == (int)updRtspPort.Value)
            {
              return true;
            }
          }
        }
      }
      return false;
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      openFileDialog.Title = "Select Video File";
      openFileDialog.Filter = "AVI File (*.avi)|*.avi|MP4 File (*.mp4)|*.mp4|M4V File (*.m4v)|*.m4v";
      openFileDialog.FilterIndex = 2;
      openFileDialog.Multiselect = false;

      if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        txtVideoFilePath.Text = openFileDialog.FileName;
      }
    }

    private void updRtspPort_ValueChanged(object sender, EventArgs e)
    {
      UpdatePortTooltip();
    }

    private void UpdatePortTooltip()
    {
      toolTips.SetToolTip(updRtspPort, "Connect to this channel using the following URL:" +
        Environment.NewLine + 
        "rtsp://<this machine's IP address>:" + ((int)updRtspPort.Value).ToString() + "/" +
        Environment.NewLine + Environment.NewLine +
        "Each channel requires a unique RTSP server port.");
    }

  }
}

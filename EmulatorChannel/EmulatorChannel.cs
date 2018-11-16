using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Emulator
{
  public enum ChannelStatus
  {
    Unknown = -1,
    Normal = 0,
    Error
  }

  public class EmulatorChannel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string MediaPath { get; set; }
    public int RtspPort { get; set; }
    public bool Enabled { get; set; }
    public ChannelStatus Status { get; set; }

    [XmlIgnore]
    public EmulatorEngine Engine { get; set; }

    public EmulatorChannel()
    {
    }

    public EmulatorChannel(int id, string name, string mediaPath, int rtspPort, bool enabled)
    {
      Id = id;
      Name = name;
      MediaPath = mediaPath;
      RtspPort = rtspPort;
      Enabled = enabled;
      Status = ChannelStatus.Unknown;
    }

  }
}

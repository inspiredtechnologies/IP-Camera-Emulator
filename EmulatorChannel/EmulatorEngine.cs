using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Emulator
{
  public class EmulatorEngine : IDisposable
  {
    private IntPtr _RstpStreamLibPointer = IntPtr.Zero;
    private EmulatorChannel _ChannelInfo = null;

    // ---------------------------------------------------------------------------

    #region Public Methods
    
    public void Start()
    {
      try
      {
        if (!File.Exists(_ChannelInfo.MediaPath))
          throw new InvalidOperationException("Invalid media file");

        Console.WriteLine("Loading media (" + _ChannelInfo.MediaPath + ")...");
        StartStream();
        Console.WriteLine("Started stream on Port " + _ChannelInfo.RtspPort.ToString());
      }
      catch
      {
        throw;
      }
    }

    public void Stop()
    {
      try
      {
        StopStream();
      }
      catch
      {
        throw;
      }
    }

    public ChannelStatus GetChannelStatus()
    {
      try
      {
        return (RtspStreamerLib.GetStreamRateLib(_RstpStreamLibPointer) <= 0) ? 
          ChannelStatus.Error : ChannelStatus.Normal;
      }
      catch
      {
        throw;
      }
    }

    public string GetVlcLibraryVersion()
    {
      try
      {
        return RtspStreamerLib.GetVlcVersion(_RstpStreamLibPointer);
      }
      catch
      {
        return "<Unknown>";
      }
    }

    #endregion

    // ---------------------------------------------------------------------------

    public EmulatorEngine(string channelName, string mediaPath, int rtspPort, bool enabled)
    {
      _ChannelInfo = new EmulatorChannel();
      _ChannelInfo.Name = channelName;
      _ChannelInfo.MediaPath = mediaPath;
      _ChannelInfo.RtspPort = rtspPort;
      _ChannelInfo.Enabled = enabled;

      try
      {
        _RstpStreamLibPointer = RtspStreamerLib.CreateRtspStreamerLib();
      }
      catch
      {
        throw;
      }
    }

    ~EmulatorEngine()
    {
      Dispose(false);
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        // free managed resources
      }
      // free native resources if there are any.
      RtspStreamerLib.DestroyRtspStreamerLib(_RstpStreamLibPointer);
      _RstpStreamLibPointer = IntPtr.Zero;
    }

    private void StartStream()
    {
      try
      {
        byte[] streamName = Encoding.UTF8.GetBytes(_ChannelInfo.Name);
        byte[] mediaPath = Encoding.UTF8.GetBytes(_ChannelInfo.MediaPath);

        RtspStreamerLib.StartStreamLib(_RstpStreamLibPointer, streamName, mediaPath, _ChannelInfo.RtspPort);
      }
      catch
      {
        throw;
      }
    }

    private void StopStream()
    {
      try
      {
        RtspStreamerLib.StopStreamLib(_RstpStreamLibPointer);
      }
      catch
      {
        throw;
      }
    }

  }
}

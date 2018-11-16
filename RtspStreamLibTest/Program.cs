using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RtspStreamLibTest
{
  class Program
  {
    static IntPtr _RtspStreamLibPointer = IntPtr.Zero;
    static bool _Terminate = false;
    static string _MediaFile = "D:/Tenders/IHIS C3/Video Clips/CH A-h.m4v";
    static int _RtspPort = 8554;

    static void Main(string[] args)
    {
      try
      {
        _RtspStreamLibPointer = RtspStreamerLib.CreateRtspStreamerLib();
        _Terminate = false;

        Console.CancelKeyPress += delegate(object sender, ConsoleCancelEventArgs e)
        {
          e.Cancel = true;
          _Terminate = true;
        };

        Console.WriteLine("Using VLC Library Version " + 
          RtspStreamerLib.GetVlcVersion(_RtspStreamLibPointer) + Environment.NewLine);

        Console.WriteLine("Loading media (" + _MediaFile + ")...");
        Thread streamThread = new Thread(new ThreadStart(StartStream));
        streamThread.IsBackground = true;
        streamThread.Start();
        //StartStream();
        Console.WriteLine("Started stream on Port " + _RtspPort.ToString());
        Console.WriteLine("Hit Ctrl-C to terminate streaming....");

        int loop = 50;
        while (!_Terminate)
        {
          Thread.Sleep(100);
          if (--loop <= 0)
          {
            loop = 50;
            if (RtspStreamerLib.GetStreamRateLib(_RtspStreamLibPointer) <= 0)
            {
              Console.WriteLine(DateTime.Now + " : Stream error detected....");
            }
          }
        }

        StopStream();
        Thread.Sleep(300);
        RtspStreamerLib.DestroyRtspStreamerLib(_RtspStreamLibPointer);
        _RtspStreamLibPointer = IntPtr.Zero;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    static void StartStream()
    {
      byte[] streamName = Encoding.UTF8.GetBytes("test");
      byte[] mediaPath = Encoding.UTF8.GetBytes(_MediaFile);

      RtspStreamerLib.StartStreamLib(_RtspStreamLibPointer, streamName, mediaPath, _RtspPort);
    }

    static void StopStream()
    {
      RtspStreamerLib.StopStreamLib(_RtspStreamLibPointer);
    }
  }
}

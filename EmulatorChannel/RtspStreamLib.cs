using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
  static class RtspStreamerLib
  {
    [DllImport("RtspStreamerLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr CreateRtspStreamerLib();

    [DllImport("RtspStreamerLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DestroyRtspStreamerLib(IntPtr lib);

    [DllImport("RtspStreamerLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern Int32 StartStreamLib(IntPtr lib, byte[] streamName, byte[] mediaPath, Int32 portNumber);

    [DllImport("RtspStreamerLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void StopStreamLib(IntPtr lib);

    [DllImport("RtspStreamerLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool GetStreamStatusLib(IntPtr lib);

    [DllImport("RtspStreamerLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern Int32 GetStreamRateLib(IntPtr lib);

    [DllImport("RtspStreamerLib.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr GetVlcVersionLib(IntPtr lib);

    public static string GetVlcVersion(IntPtr lib)
    {
      byte[] retPtr = new byte[64];
      System.Runtime.InteropServices.Marshal.Copy(RtspStreamerLib.GetVlcVersionLib(lib), retPtr, 0, 64);
      return Encoding.UTF8.GetString(retPtr);
    }

  }
}

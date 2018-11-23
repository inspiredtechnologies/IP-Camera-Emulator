# IpCameraEmulator
IP Camera Emulator - A Windows .NET app that emulates one or more RTSP video cameras

This software tool was created to perform load testing of video management software and CCTV network video recorders. It makes use of the VLC libraries to generate RTSP video streams from video files. The software requires these library components in the application folder:

* RtspStreamerLib.dll (C++ DLL from the RtspStreamerLib project)
* libvlc.dll, libvlccore.dll and the plugins folder from VLC (32-bit editions. Ver 2.2.6, 1.1.9 seem to work well)
* SystemMetrics .NET library (https://github.com/inspiredtechnologies/SystemMetrics/)

To build the RtspStreamerLib DLL, you will need the VLC SDK C++ headers and 32-bit MSVC libraries (try https://github.com/RSATom/libvlc-sdk). I was also able to generate the required LIB files from the official VLC DLLs (http://www.asawicki.info/news_1420_generating_lib_file_for_dll_library.html).



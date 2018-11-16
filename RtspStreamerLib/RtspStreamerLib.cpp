// RtspStreamerLib.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "RtspStreamerLib.h"

RTSPSTREAMERLIB_API void* CreateRtspStreamerLib(void)
{
	return new CRtspStreamerLib();
}

RTSPSTREAMERLIB_API void DestroyRtspStreamerLib(void* pLib)
{
	if (pLib != NULL)
	{
		CRtspStreamerLib *lib = (CRtspStreamerLib*)pLib;
		delete lib;
	}
}

RTSPSTREAMERLIB_API int StartStreamLib(void* pLib, char* streamName, char* mediaPath, int portNumber)
{
	if (pLib != NULL)
	{
		CRtspStreamerLib *lib = (CRtspStreamerLib*)pLib;
		return lib->StartStream(streamName, mediaPath, portNumber);
	}
	return RET_FAILED;
}

RTSPSTREAMERLIB_API void StopStreamLib(void* pLib)
{
	if (pLib != NULL)
	{
		CRtspStreamerLib *lib = (CRtspStreamerLib*)pLib;
		lib->StopStream();
	}
}

RTSPSTREAMERLIB_API BOOL GetStreamStatusLib(void* pLib)
{
	if (pLib != NULL)
	{
		CRtspStreamerLib *lib = (CRtspStreamerLib*)pLib;
		return lib->_IsStreaming;
	}
	return false;
}

RTSPSTREAMERLIB_API int GetStreamRateLib(void* pLib)
{
	if (pLib != NULL)
	{
		CRtspStreamerLib *lib = (CRtspStreamerLib*)pLib;
		return lib->GetStreamRate();
	}
	return RET_FAILED;
}

RTSPSTREAMERLIB_API char* GetVlcVersionLib(void* pLib)
{
	if (pLib != NULL)
	{
		CRtspStreamerLib *lib = (CRtspStreamerLib*)pLib;
		return lib->GetVlcVersion();
	}
	return NULL;
}

// ---------------------------------------------------------------------

// This is the constructor of a class that has been exported.
// see RtspStreamerLib.h for the class definition
CRtspStreamerLib::CRtspStreamerLib()
{
	return;
}

CRtspStreamerLib::~CRtspStreamerLib()
{
	CloseInstance();
}

void CRtspStreamerLib::CloseInstance()
{
	if (_IsStreaming)
	{
		StopStream();
	}
}

int CRtspStreamerLib::StartStream(char* streamName, char* mediaPath, int portNumber)
{
	if (mediaPath != NULL)
	{
		//DWORD threadId = 0;
		_StreamName = streamName;
		_MediaPath = mediaPath;
		_Port = portNumber;
		InitiateStreaming();
		return RET_SUCCESS;
	}
	else return RET_FAILED;
}

void CRtspStreamerLib::StopStream()
{
	//libvlc_event_detach(_Event_Mgr, libvlc_VlmMediaInstanceStopped, VlcEvent, this);
	libvlc_vlm_stop_media(_VlcInstance, _StreamName.c_str());
	libvlc_vlm_del_media(_VlcInstance, _StreamName.c_str());
	libvlc_vlm_release(_VlcInstance);
	_VlcInstance = NULL;
	_IsStreaming = FALSE;
}

void CRtspStreamerLib::InitiateStreaming()
{
	char *vlc_argv[6];
	vlc_argv[0] = new char[3];
	strcpy_s(vlc_argv[0], 3, "-I");
	vlc_argv[1] = new char[6];
	strcpy_s(vlc_argv[1], 6, "dummy"); // Don't use any interface
	vlc_argv[2] = new char[32];
	strcpy_s(vlc_argv[2], 32, "--ignore-config"); // Don't use VLC's config
	vlc_argv[3] = new char[128];
	strcpy_s(vlc_argv[3], 128, "--plugin-path=/plugins");
	vlc_argv[4] = new char[128];
	strcpy_s(vlc_argv[4], 128, "--network-caching=300");
	//vlc_argv[5] = new char[128];
	//strcpy_s(vlc_argv[5], 128, "--input-repeat=-1");
	int vlc_argc = 5;		// 6;

	_VlcInstance = libvlc_new(vlc_argc, vlc_argv);

	for (int i = 0; i < vlc_argc; i++)
		delete[] vlc_argv[i];

	std::ostringstream portNumber;
	portNumber << _Port;
	
	string sout = "#transcode{acodec=none}:rtp{sdp=rtsp://:" + portNumber.str() + "/}";
	const char * const options[] = { ":sout-keep", ":sout-no-audio" };

	libvlc_vlm_add_broadcast(_VlcInstance, _StreamName.c_str(), ("file:///" + _MediaPath).c_str(),
		sout.c_str(), 2, options, true, true);
	
	libvlc_vlm_play_media(_VlcInstance, _StreamName.c_str());
	//_Event_Mgr = libvlc_vlm_get_event_manager(_VlcInstance);
	//if (_Event_Mgr != NULL)
	//{
	//	libvlc_event_attach(_Event_Mgr, libvlc_VlmMediaInstanceStopped, VlcEvent, this);
	//}
	_IsStreaming = TRUE;
}

void CRtspStreamerLib::RestartStreaming()
{
	if (_VlcInstance != NULL)
	{
		libvlc_vlm_stop_media(_VlcInstance, _StreamName.c_str());
		libvlc_vlm_play_media(_VlcInstance, _StreamName.c_str());
	}
}

void CRtspStreamerLib::VlcEvent(const libvlc_event_t* event, void* ptr)
{
	CRtspStreamerLib* self = reinterpret_cast<CRtspStreamerLib*>(ptr);
	if (event->type == libvlc_VlmMediaInstanceStopped)
	{
		thread th(&CRtspStreamerLib::RestartStreaming, self);
		th.detach();
	}
}

int CRtspStreamerLib::GetStreamRate()
{
	if (_VlcInstance != NULL)
	{
		return libvlc_vlm_get_media_instance_rate(_VlcInstance, _StreamName.c_str(), 0);
	}
	return RET_FAILED;
}

char* CRtspStreamerLib::GetVlcVersion()
{
	return (char *)libvlc_get_version();
}
	

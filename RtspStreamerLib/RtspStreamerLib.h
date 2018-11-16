// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the RTSPSTREAMERLIB_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// RTSPSTREAMERLIB_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef RTSPSTREAMERLIB_EXPORTS
#define RTSPSTREAMERLIB_API __declspec(dllexport)
#else
#define RTSPSTREAMERLIB_API __declspec(dllimport)
#endif

#include "vlc/vlc.h"
#include <iostream>
#include <sstream>
#include <stdio.h>
#include <thread>
#include <windows.h>

using namespace std;

#define RET_FAILED		-1
#define RET_SUCCESS		0

// This class is exported from the RtspStreamerLib.dll
class CRtspStreamerLib 
{
public:
	BOOL _IsStreaming = FALSE;

private:
	string _StreamName;
	string _MediaPath;
	int _Port = 8554;
	//HANDLE _StreamThread = NULL;
	libvlc_instance_t *_VlcInstance = NULL;
	libvlc_event_manager_t *_Event_Mgr = NULL;

public:
	CRtspStreamerLib(void);
	~CRtspStreamerLib(void);
	void CloseInstance(void);
	int StartStream(char* streamName, char* mediaPath, int portNumber);
	void InitiateStreaming(void);
	void StopStream();
	int GetStreamRate(void);
	void RestartStreaming(void);
	char* GetVlcVersion(void);

private:
	static void VlcEvent(const libvlc_event_t* event, void* ptr);
};

RTSPSTREAMERLIB_API void* CreateRtspStreamerLib(void);
RTSPSTREAMERLIB_API void DestroyRtspStreamerLib(void* pLib);
RTSPSTREAMERLIB_API int StartStreamLib(void* pLib, char* streamName, char* mediaPath, int portNumber);
RTSPSTREAMERLIB_API void StopStreamLib(void* pLib);
RTSPSTREAMERLIB_API BOOL GetStreamStatusLib(void* pLib);
RTSPSTREAMERLIB_API int GetStreamRateLib(void* pLib);
RTSPSTREAMERLIB_API char* GetVlcVersionLib(void* pLib);


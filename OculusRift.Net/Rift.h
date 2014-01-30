// OculusRift ネイティブクラス

#pragma once

//Oculus SDK Header
#include "../LibOVR/Include/OVR.h"

//Oculus SDK Lib
#ifdef _DEBUG
#pragma comment(lib, "../LibOVR/Lib/Win32/libovrd.lib")
#else
#pragma comment(lib, "../LibOVR/Lib/Win32/libovr.lib")
#endif

//Additional lib
#pragma comment(lib, "winmm.lib")
#pragma comment(lib, "user32.lib")

//OculusRift Native Class
class Rift {
	//Device
	OVR::Ptr<OVR::DeviceManager> pManager;
	OVR::Ptr<OVR::HMDDevice> pHMD;
	OVR::Ptr<OVR::SensorDevice> pSensor;
	OVR::SensorFusion* pFusionResult;			//Need to declare as pointer
	
	//Pose
	OVR::Quatf quaternion;
	float yaw;
	float pitch;
	float roll;

	//Device Informatin
	OVR::HMDInfo hmdInfo;

public:
	//Constructor
	Rift() {
	}

	//Destructor
	~Rift()	{
	}

	//Initialize
	void Init() {
		//SDK Initialize
		OVR::System::Init(OVR::Log::ConfigureDefaultLog(OVR::LogMask_All));

		//Device Manager
		pManager = *OVR::DeviceManager::Create();

		//HMD Device
		pHMD = *pManager->EnumerateDevices<OVR::HMDDevice>().CreateDevice();

		//Sensor
		if(pHMD) {
			pHMD->GetDeviceInfo(&hmdInfo);

			pSensor = *pHMD->GetSensor();
		}

		//Attach to sensor fusion
		if(pSensor) {
			pFusionResult = new OVR::SensorFusion();
			pFusionResult->AttachToSensor(pSensor);
		}
	}

	//Exit
	void Close() {
		pSensor.Clear();
		pHMD.Clear();
		pManager.Clear();

		delete pFusionResult;

		OVR::System::Destroy();
	}

	//Get HMD pose as quaternion
	void GetQuaternion(float* x, float* y, float* z, float*w) {
		if(pFusionResult->IsAttachedToSensor())
		{
			OVR::Quatf quaternion = pFusionResult->GetOrientation();
			*x = quaternion.x;
			*y = quaternion.y;
			*z = quaternion.z;
			*w = quaternion.w;
		}
	}

	//Get HMd pose as euler angles
	void GetEulerAngles(float* yaw, float* pitch, float* roll) {
		if(pFusionResult->IsAttachedToSensor())
		{
			pFusionResult->GetOrientation().GetEulerAngles<OVR::Axis_Y, OVR::Axis_X, OVR::Axis_Z>(yaw, pitch, roll);
		}
	}

	//Set sensor (yaw) value to zero
	void Reset()
	{
		if(pFusionResult->IsAttachedToSensor())
		{
			pFusionResult->Reset();
		}
	}

	//Get device information (resolution, distortion k value etc.)
	OVR::HMDInfo GetHMDInfo()
	{
		return hmdInfo;
	}
};

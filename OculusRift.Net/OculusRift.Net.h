// OculusRift.Net.h

#pragma once

//OculusRift native class
#include "Rift.h"

//CLR
#include "DeviceInfo.h"
#include "Orientation.h"

using namespace System;

namespace OculusRiftNet {

	public ref class Ovr
	{
		Rift* pRift;		//Native class

		DeviceInfo^ hmdInfo;
		Orientation^ pose;

	private:
		//Set device infromation to CLR
		void GetHmdInfo()
		{
			hmdInfo->MonitorName = gcnew String(pRift->GetHMDInfo().DisplayDeviceName);
			hmdInfo->HResolution = pRift->GetHMDInfo().HResolution;
			hmdInfo->VResolution = pRift->GetHMDInfo().VResolution;
			hmdInfo->HScreenSize = pRift->GetHMDInfo().HScreenSize;
			hmdInfo->VScreenSize = pRift->GetHMDInfo().VScreenSize;
			hmdInfo->EyeToScreenDistance = pRift->GetHMDInfo().EyeToScreenDistance;
			hmdInfo->LensSeparationDistance = pRift->GetHMDInfo().LensSeparationDistance;
			hmdInfo->InterpupillaryDistance = pRift->GetHMDInfo().InterpupillaryDistance;
			hmdInfo->DistortionK[0] = pRift->GetHMDInfo().DistortionK[0];
			hmdInfo->DistortionK[1] = pRift->GetHMDInfo().DistortionK[1];
			hmdInfo->DistortionK[2] = pRift->GetHMDInfo().DistortionK[2];
			hmdInfo->DistortionK[3] = pRift->GetHMDInfo().DistortionK[3];
			hmdInfo->DesktopX = pRift->GetHMDInfo().DesktopX;
			hmdInfo->DesktopY = pRift->GetHMDInfo().DesktopY;
		}

		//Set quaternion value to CLR
		void GetQuaternion()
		{
			float x;
			float y;
			float z;
			float w;
			pRift->GetQuaternion(&x, &y, &z, &w);

			pose->Quat->X = x;
			pose->Quat->Y = x;
			pose->Quat->Z = x;
			pose->Quat->W = x;
		}

		//Set euler angles to CLR
		void GetEulerAngles()
		{
			float yaw;
			float pitch;
			float roll;
			pRift->GetEulerAngles(&yaw, &pitch, &roll);

			pose->Angles->Yaw = yaw;
			pose->Angles->Pitch = pitch;
			pose->Angles->Roll = roll;
		}

	public:		
		//Constructor
		Ovr()
		{
			pRift = new Rift;

			hmdInfo = gcnew DeviceInfo();
			pose = gcnew Orientation();
		}
		
		//Destructor
		~Ovr()
		{
			delete pRift;
		}
		
		//Property
		property DeviceInfo^ HMDInfo
		{
			DeviceInfo^ get() { return hmdInfo; }
		}

		//Property
		property Orientation^ Pose
		{
			Orientation^ get() { return pose; }
		}

		//Initiazling HMD
		//Call Init() function of native class
		void Init()
		{
			pRift->Init();
			
			GetHmdInfo();
		}

		//Closing HMD
		//Call Close() function of native class
		void Close()
		{
			pRift->Close();
		}

		//Update HMD pose
		//Set sensor values to CLR
		void UpdateSensors()
		{
			GetQuaternion();
			GetEulerAngles();
		}

		//Reset sensor value (yaw)
		//Call Rset() function of native class
		void ResetSensors()
		{
			pRift->Reset();
		}
	};
}

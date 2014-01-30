#pragma once

using namespace System;

	public ref class DeviceInfo
	{
		String^ monitorName;
		int hResolution;
		int vResolution;
		float hScreenSize;
		float vScreenSize;
		float eyeToScreenDistance;
		float lensSeparationDistance;
		float interpupillaryDistance;
		array<float>^ pDistortionK;
		int desktopX;
		int desktopY;

	public:
		DeviceInfo()
		{
			 pDistortionK = gcnew array<float>(4);
		}

		~DeviceInfo()
		{
		}
		
		property String^ MonitorName
		{
			String^ get() { return monitorName; }
			void set(String^ value) { monitorName = value; }
		}

		property int HResolution
		{
			int get() { return hResolution; }
			void set(int value) { hResolution = value; }
		}

		property int VResolution
		{
			int get() { return vResolution; }
			void set(int value) { vResolution = value; }
		}

		property float HScreenSize
		{
			float get() { return hScreenSize; }
			void set(float value) { hScreenSize = value; }
		}

		property float VScreenSize
		{
			float get() { return vScreenSize; }
			void set(float value) { vScreenSize = value; }
		}

		property float EyeToScreenDistance
		{
			float get() { return eyeToScreenDistance; }
			void set(float value) { eyeToScreenDistance = value; }
		}

		property float LensSeparationDistance
		{
			float get() { return lensSeparationDistance; }
			void set(float value) { lensSeparationDistance = value; }
		}

		property float InterpupillaryDistance
		{
			float get() { return interpupillaryDistance; }
			void set(float value) { interpupillaryDistance = value; }
		}

		property array<float>^ DistortionK
		{
			array<float>^ get() { return pDistortionK; }
			void set(array<float>^ value) 
			{
				pDistortionK[0] = value[0];
				pDistortionK[1] = value[1];
				pDistortionK[2] = value[2];
				pDistortionK[3] = value[3];
			}
		}

		property int DesktopX
		{
			int get() { return desktopX; }
			void set(int value) { desktopX = value;}
		}

		property int DesktopY
		{
			int get() { return desktopY; }
			void set(int value) { desktopY = value;}
		}
	};

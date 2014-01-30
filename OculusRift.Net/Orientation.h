#pragma once

#include "EulerAngles.h"
#include "Quaternion.h"

using namespace System;

public ref class Orientation
{
	EulerAngles^ angles;
	Quaternion^ quat;

public:
	Orientation()
	{
		angles = gcnew EulerAngles();
		quat = gcnew Quaternion();
	}

	~Orientation()
	{
	}

	property EulerAngles^ Angles
	{
		EulerAngles^ get() { return angles; }
		void set(EulerAngles^ value)
		{
			angles->Yaw = value->Yaw;
			angles->Pitch = value->Pitch;
			angles->Roll = value->Roll;
		}
	}

	property Quaternion^ Quat
	{
		Quaternion^ get() { return quat; }
		void set(Quaternion^ value)
		{
			quat->X = value->X;
			quat->Y = value->Y;
			quat->Z = value->Z;
			quat->W = value->W;
		}
	}
};


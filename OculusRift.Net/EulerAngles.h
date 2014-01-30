#pragma once

using namespace System;

public ref class EulerAngles
{
	float yaw;
	float pitch;
	float roll;

public:
	EulerAngles()
	{
	}

	~EulerAngles()
	{
	}

	property float Yaw
	{
		float get() { return yaw; }
		void set(float value) { yaw = value; }
	}

	property float Pitch
	{
		float get() { return pitch; }
		void set(float value) { pitch = value; }
	}

	property float Roll
	{
		float get() { return roll; }
		void set(float value) { roll = value; }
	}
};


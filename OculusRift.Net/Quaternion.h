#pragma once

public ref class Quaternion
{
	float x;
	float y;
	float z;
	float w;

public:
	Quaternion()
	{
	}
	
	~Quaternion()
	{
	}

	property float X
	{
		float get() { return x; }
		void set(float value) { x = value; }
	}

	property float Y
	{
		float get() { return Y; }
		void set(float value) { y = value; }
	}

	property float Z
	{
		float get() { return z; }
		void set(float value) { z = value; }
	}

	property float W
	{
		float get() { return w; }
		void set(float value) { w = value; }
	}
};


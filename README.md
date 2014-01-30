OculusRift_for_.NET
===================
This project is a .NET wrapper for the Oculus SDK 0.2.5. 

This provide very basic features to access sensor fusion (orientation of HMD) from C# code.
It includes following features:
- Initilizing HMD
- Getting device information (resolution, distortion k value etc.)
- Getting HMD pose with quaternion and euler angels
- Setting zero value to HMD sensor
- Closing HMD

VS2010 solution
===================
This code is implemented with Microsoft VisualStudio 2010. It consists of:

OculusRift.Net
===================
This is a C++/CLI project wrapping Oculus SDK C++ library. It generate "OculusRift.Net.Dll".

Note that I do not include LibOVR project because I do not know the licesing of the SDK. Please add "LibOVR_Msvc2010.vcxproj" of the SDK, or manually add location of the SDK header files and .lib files in the code.

OculusTest
===================

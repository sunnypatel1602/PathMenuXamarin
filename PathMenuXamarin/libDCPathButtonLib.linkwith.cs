using System;
using ObjCRuntime;

[assembly: LinkWith ("libDCPathButtonLib.a",LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]

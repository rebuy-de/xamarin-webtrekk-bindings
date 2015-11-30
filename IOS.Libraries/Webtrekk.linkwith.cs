using ObjCRuntime;
using Foundation;

[assembly: LinkWith ("Webtrekk.a", LinkTarget.Arm64 | LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, IsCxx = true)]

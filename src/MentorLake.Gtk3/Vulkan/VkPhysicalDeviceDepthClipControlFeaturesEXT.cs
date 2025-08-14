namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDepthClipControlFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDepthClipControlFeaturesEXTExtensions
{

	public static VkPhysicalDeviceDepthClipControlFeaturesEXT Dereference(this VkPhysicalDeviceDepthClipControlFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDepthClipControlFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDepthClipControlFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceDepthClipControlFeaturesEXT
{
}

namespace MentorLake.Vulkan;


public class VkPhysicalDeviceOpacityMicromapFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceOpacityMicromapFeaturesEXTExtensions
{

	public static VkPhysicalDeviceOpacityMicromapFeaturesEXT Dereference(this VkPhysicalDeviceOpacityMicromapFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceOpacityMicromapFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceOpacityMicromapFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
{
}

namespace MentorLake.Vulkan;


public class VkPhysicalDeviceOpacityMicromapPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceOpacityMicromapPropertiesEXTExtensions
{

	public static VkPhysicalDeviceOpacityMicromapPropertiesEXT Dereference(this VkPhysicalDeviceOpacityMicromapPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceOpacityMicromapPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceOpacityMicromapPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceOpacityMicromapPropertiesEXT
{
}

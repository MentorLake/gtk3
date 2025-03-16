namespace MentorLake.Vulkan;

public class VkPhysicalDeviceImageViewImageFormatInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageViewImageFormatInfoEXTExtensions
{

	public static VkPhysicalDeviceImageViewImageFormatInfoEXT Dereference(this VkPhysicalDeviceImageViewImageFormatInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageViewImageFormatInfoEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageViewImageFormatInfoEXTExterns
{
}

public struct VkPhysicalDeviceImageViewImageFormatInfoEXT
{
}

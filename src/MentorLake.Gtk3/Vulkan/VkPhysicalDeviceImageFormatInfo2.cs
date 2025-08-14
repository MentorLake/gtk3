namespace MentorLake.Vulkan;


public class VkPhysicalDeviceImageFormatInfo2Handle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageFormatInfo2Extensions
{

	public static VkPhysicalDeviceImageFormatInfo2 Dereference(this VkPhysicalDeviceImageFormatInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageFormatInfo2>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageFormatInfo2Externs
{
}


public struct VkPhysicalDeviceImageFormatInfo2
{
}

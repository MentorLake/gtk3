namespace MentorLake.Vulkan;


public class VkPhysicalDeviceImageFormatInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageFormatInfo2KHRExtensions
{

	public static VkPhysicalDeviceImageFormatInfo2KHR Dereference(this VkPhysicalDeviceImageFormatInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageFormatInfo2KHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageFormatInfo2KHRExterns
{
}


public struct VkPhysicalDeviceImageFormatInfo2KHR
{
}

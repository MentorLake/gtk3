namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExternalImageFormatInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalImageFormatInfoKHRExtensions
{

	public static VkPhysicalDeviceExternalImageFormatInfoKHR Dereference(this VkPhysicalDeviceExternalImageFormatInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalImageFormatInfoKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalImageFormatInfoKHRExterns
{
}


public struct VkPhysicalDeviceExternalImageFormatInfoKHR
{
}

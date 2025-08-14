namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVideoFormatInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVideoFormatInfoKHRExtensions
{

	public static VkPhysicalDeviceVideoFormatInfoKHR Dereference(this VkPhysicalDeviceVideoFormatInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVideoFormatInfoKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVideoFormatInfoKHRExterns
{
}


public struct VkPhysicalDeviceVideoFormatInfoKHR
{
}

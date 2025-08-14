namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExternalFenceInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalFenceInfoKHRExtensions
{

	public static VkPhysicalDeviceExternalFenceInfoKHR Dereference(this VkPhysicalDeviceExternalFenceInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalFenceInfoKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalFenceInfoKHRExterns
{
}


public struct VkPhysicalDeviceExternalFenceInfoKHR
{
}

namespace MentorLake.Vulkan;


public class VkPhysicalDeviceTimelineSemaphoreFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTimelineSemaphoreFeaturesKHRExtensions
{

	public static VkPhysicalDeviceTimelineSemaphoreFeaturesKHR Dereference(this VkPhysicalDeviceTimelineSemaphoreFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTimelineSemaphoreFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTimelineSemaphoreFeaturesKHRExterns
{
}


public struct VkPhysicalDeviceTimelineSemaphoreFeaturesKHR
{
}

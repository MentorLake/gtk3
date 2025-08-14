namespace MentorLake.Vulkan;


public class VkPhysicalDevicePerformanceQueryFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePerformanceQueryFeaturesKHRExtensions
{

	public static VkPhysicalDevicePerformanceQueryFeaturesKHR Dereference(this VkPhysicalDevicePerformanceQueryFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePerformanceQueryFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePerformanceQueryFeaturesKHRExterns
{
}


public struct VkPhysicalDevicePerformanceQueryFeaturesKHR
{
}

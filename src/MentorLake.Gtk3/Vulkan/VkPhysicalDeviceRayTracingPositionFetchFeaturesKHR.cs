namespace MentorLake.Vulkan;

public class VkPhysicalDeviceRayTracingPositionFetchFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRayTracingPositionFetchFeaturesKHRExtensions
{

	public static VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR Dereference(this VkPhysicalDeviceRayTracingPositionFetchFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRayTracingPositionFetchFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR
{
}

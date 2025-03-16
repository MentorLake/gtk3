namespace MentorLake.Vulkan;

public class VkPhysicalDeviceGlobalPriorityQueryFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceGlobalPriorityQueryFeaturesKHRExtensions
{

	public static VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR Dereference(this VkPhysicalDeviceGlobalPriorityQueryFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceGlobalPriorityQueryFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
{
}

namespace MentorLake.Vulkan;

public class VkPhysicalDeviceRayQueryFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRayQueryFeaturesKHRExtensions
{

	public static VkPhysicalDeviceRayQueryFeaturesKHR Dereference(this VkPhysicalDeviceRayQueryFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRayQueryFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRayQueryFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceRayQueryFeaturesKHR
{
}

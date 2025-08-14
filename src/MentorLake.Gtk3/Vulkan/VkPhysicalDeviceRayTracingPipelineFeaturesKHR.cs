namespace MentorLake.Vulkan;


public class VkPhysicalDeviceRayTracingPipelineFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRayTracingPipelineFeaturesKHRExtensions
{

	public static VkPhysicalDeviceRayTracingPipelineFeaturesKHR Dereference(this VkPhysicalDeviceRayTracingPipelineFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRayTracingPipelineFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRayTracingPipelineFeaturesKHRExterns
{
}


public struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
{
}

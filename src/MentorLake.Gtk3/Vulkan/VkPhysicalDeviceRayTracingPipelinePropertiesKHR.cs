namespace MentorLake.Vulkan;

public class VkPhysicalDeviceRayTracingPipelinePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRayTracingPipelinePropertiesKHRExtensions
{

	public static VkPhysicalDeviceRayTracingPipelinePropertiesKHR Dereference(this VkPhysicalDeviceRayTracingPipelinePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRayTracingPipelinePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRayTracingPipelinePropertiesKHRExterns
{
}

public struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
{
}

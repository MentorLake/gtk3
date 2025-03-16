namespace MentorLake.Vulkan;

public class VkRayTracingPipelineCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRayTracingPipelineCreateInfoKHRExtensions
{

	public static VkRayTracingPipelineCreateInfoKHR Dereference(this VkRayTracingPipelineCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRayTracingPipelineCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkRayTracingPipelineCreateInfoKHRExterns
{
}

public struct VkRayTracingPipelineCreateInfoKHR
{
}

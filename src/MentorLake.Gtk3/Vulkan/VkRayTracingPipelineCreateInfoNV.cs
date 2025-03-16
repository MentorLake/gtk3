namespace MentorLake.Vulkan;

public class VkRayTracingPipelineCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkRayTracingPipelineCreateInfoNVExtensions
{

	public static VkRayTracingPipelineCreateInfoNV Dereference(this VkRayTracingPipelineCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRayTracingPipelineCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkRayTracingPipelineCreateInfoNVExterns
{
}

public struct VkRayTracingPipelineCreateInfoNV
{
}

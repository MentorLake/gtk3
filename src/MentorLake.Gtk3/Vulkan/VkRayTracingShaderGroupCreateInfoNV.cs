namespace MentorLake.Vulkan;

public class VkRayTracingShaderGroupCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkRayTracingShaderGroupCreateInfoNVExtensions
{

	public static VkRayTracingShaderGroupCreateInfoNV Dereference(this VkRayTracingShaderGroupCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRayTracingShaderGroupCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkRayTracingShaderGroupCreateInfoNVExterns
{
}

public struct VkRayTracingShaderGroupCreateInfoNV
{
}

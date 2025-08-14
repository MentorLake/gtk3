namespace MentorLake.Vulkan;


public class VkRayTracingShaderGroupTypeNVHandle : BaseSafeHandle
{
}


public static class VkRayTracingShaderGroupTypeNVExtensions
{

	public static VkRayTracingShaderGroupTypeNV Dereference(this VkRayTracingShaderGroupTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRayTracingShaderGroupTypeNV>(x.DangerousGetHandle());
}
internal class VkRayTracingShaderGroupTypeNVExterns
{
}


public struct VkRayTracingShaderGroupTypeNV
{
}

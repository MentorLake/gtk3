namespace MentorLake.Vulkan;


public class VkRayTracingShaderGroupTypeKHRHandle : BaseSafeHandle
{
}


public static class VkRayTracingShaderGroupTypeKHRExtensions
{

	public static VkRayTracingShaderGroupTypeKHR Dereference(this VkRayTracingShaderGroupTypeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRayTracingShaderGroupTypeKHR>(x.DangerousGetHandle());
}
internal class VkRayTracingShaderGroupTypeKHRExterns
{
}


public struct VkRayTracingShaderGroupTypeKHR
{
}

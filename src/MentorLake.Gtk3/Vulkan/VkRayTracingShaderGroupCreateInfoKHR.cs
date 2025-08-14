namespace MentorLake.Vulkan;


public class VkRayTracingShaderGroupCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRayTracingShaderGroupCreateInfoKHRExtensions
{

	public static VkRayTracingShaderGroupCreateInfoKHR Dereference(this VkRayTracingShaderGroupCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRayTracingShaderGroupCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkRayTracingShaderGroupCreateInfoKHRExterns
{
}


public struct VkRayTracingShaderGroupCreateInfoKHR
{
}

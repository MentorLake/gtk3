namespace MentorLake.Vulkan;


public class VkRayTracingInvocationReorderModeNVHandle : BaseSafeHandle
{
}


public static class VkRayTracingInvocationReorderModeNVExtensions
{

	public static VkRayTracingInvocationReorderModeNV Dereference(this VkRayTracingInvocationReorderModeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRayTracingInvocationReorderModeNV>(x.DangerousGetHandle());
}
internal class VkRayTracingInvocationReorderModeNVExterns
{
}


public struct VkRayTracingInvocationReorderModeNV
{
}

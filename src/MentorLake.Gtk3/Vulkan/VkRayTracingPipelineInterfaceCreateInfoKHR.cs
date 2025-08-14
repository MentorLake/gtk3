namespace MentorLake.Vulkan;


public class VkRayTracingPipelineInterfaceCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRayTracingPipelineInterfaceCreateInfoKHRExtensions
{

	public static VkRayTracingPipelineInterfaceCreateInfoKHR Dereference(this VkRayTracingPipelineInterfaceCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRayTracingPipelineInterfaceCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkRayTracingPipelineInterfaceCreateInfoKHRExterns
{
}


public struct VkRayTracingPipelineInterfaceCreateInfoKHR
{
}

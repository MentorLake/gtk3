namespace MentorLake.Vulkan;

public class VkPipelineRenderingCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineRenderingCreateInfoKHRExtensions
{

	public static VkPipelineRenderingCreateInfoKHR Dereference(this VkPipelineRenderingCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRenderingCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkPipelineRenderingCreateInfoKHRExterns
{
}

public struct VkPipelineRenderingCreateInfoKHR
{
}

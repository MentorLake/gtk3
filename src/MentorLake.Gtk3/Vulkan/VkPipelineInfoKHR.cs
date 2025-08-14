namespace MentorLake.Vulkan;


public class VkPipelineInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineInfoKHRExtensions
{

	public static VkPipelineInfoKHR Dereference(this VkPipelineInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineInfoKHR>(x.DangerousGetHandle());
}
internal class VkPipelineInfoKHRExterns
{
}


public struct VkPipelineInfoKHR
{
}

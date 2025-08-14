namespace MentorLake.Vulkan;


public class VkPipelineCreateFlags2CreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineCreateFlags2CreateInfoKHRExtensions
{

	public static VkPipelineCreateFlags2CreateInfoKHR Dereference(this VkPipelineCreateFlags2CreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreateFlags2CreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkPipelineCreateFlags2CreateInfoKHRExterns
{
}


public struct VkPipelineCreateFlags2CreateInfoKHR
{
}

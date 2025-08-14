namespace MentorLake.Vulkan;


public class VkPipelineCreateFlags2KHRHandle : BaseSafeHandle
{
}


public static class VkPipelineCreateFlags2KHRExtensions
{

	public static VkPipelineCreateFlags2KHR Dereference(this VkPipelineCreateFlags2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreateFlags2KHR>(x.DangerousGetHandle());
}
internal class VkPipelineCreateFlags2KHRExterns
{
}


public struct VkPipelineCreateFlags2KHR
{
}

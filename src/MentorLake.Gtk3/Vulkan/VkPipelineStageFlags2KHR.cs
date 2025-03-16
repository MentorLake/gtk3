namespace MentorLake.Vulkan;

public class VkPipelineStageFlags2KHRHandle : BaseSafeHandle
{
}


public static class VkPipelineStageFlags2KHRExtensions
{

	public static VkPipelineStageFlags2KHR Dereference(this VkPipelineStageFlags2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineStageFlags2KHR>(x.DangerousGetHandle());
}
internal class VkPipelineStageFlags2KHRExterns
{
}

public struct VkPipelineStageFlags2KHR
{
}

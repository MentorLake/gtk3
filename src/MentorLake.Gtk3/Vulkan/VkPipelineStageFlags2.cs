namespace MentorLake.Vulkan;

public class VkPipelineStageFlags2Handle : BaseSafeHandle
{
}


public static class VkPipelineStageFlags2Extensions
{

	public static VkPipelineStageFlags2 Dereference(this VkPipelineStageFlags2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineStageFlags2>(x.DangerousGetHandle());
}
internal class VkPipelineStageFlags2Externs
{
}

public struct VkPipelineStageFlags2
{
}

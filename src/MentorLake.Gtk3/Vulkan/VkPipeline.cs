namespace MentorLake.Vulkan;


public class VkPipelineHandle : BaseSafeHandle
{
}


public static class VkPipelineExtensions
{

	public static VkPipeline Dereference(this VkPipelineHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipeline>(x.DangerousGetHandle());
}
internal class VkPipelineExterns
{
}


public struct VkPipeline
{
}

namespace MentorLake.Vulkan;


public class VkPipelineStageFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineStageFlagsExtensions
{

	public static VkPipelineStageFlags Dereference(this VkPipelineStageFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineStageFlags>(x.DangerousGetHandle());
}
internal class VkPipelineStageFlagsExterns
{
}


public struct VkPipelineStageFlags
{
}

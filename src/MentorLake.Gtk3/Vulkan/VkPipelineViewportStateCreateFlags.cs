namespace MentorLake.Vulkan;


public class VkPipelineViewportStateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineViewportStateCreateFlagsExtensions
{

	public static VkPipelineViewportStateCreateFlags Dereference(this VkPipelineViewportStateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineViewportStateCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineViewportStateCreateFlagsExterns
{
}


public struct VkPipelineViewportStateCreateFlags
{
}

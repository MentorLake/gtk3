namespace MentorLake.Vulkan;


public class VkPipelineColorBlendStateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineColorBlendStateCreateFlagsExtensions
{

	public static VkPipelineColorBlendStateCreateFlags Dereference(this VkPipelineColorBlendStateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineColorBlendStateCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineColorBlendStateCreateFlagsExterns
{
}


public struct VkPipelineColorBlendStateCreateFlags
{
}

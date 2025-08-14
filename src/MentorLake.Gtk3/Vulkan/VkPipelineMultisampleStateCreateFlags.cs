namespace MentorLake.Vulkan;


public class VkPipelineMultisampleStateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineMultisampleStateCreateFlagsExtensions
{

	public static VkPipelineMultisampleStateCreateFlags Dereference(this VkPipelineMultisampleStateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineMultisampleStateCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineMultisampleStateCreateFlagsExterns
{
}


public struct VkPipelineMultisampleStateCreateFlags
{
}

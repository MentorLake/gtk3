namespace MentorLake.Vulkan;


public class VkPipelineTessellationStateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineTessellationStateCreateFlagsExtensions
{

	public static VkPipelineTessellationStateCreateFlags Dereference(this VkPipelineTessellationStateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineTessellationStateCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineTessellationStateCreateFlagsExterns
{
}


public struct VkPipelineTessellationStateCreateFlags
{
}

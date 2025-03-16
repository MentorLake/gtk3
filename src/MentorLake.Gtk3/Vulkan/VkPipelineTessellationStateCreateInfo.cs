namespace MentorLake.Vulkan;

public class VkPipelineTessellationStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineTessellationStateCreateInfoExtensions
{

	public static VkPipelineTessellationStateCreateInfo Dereference(this VkPipelineTessellationStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineTessellationStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineTessellationStateCreateInfoExterns
{
}

public struct VkPipelineTessellationStateCreateInfo
{
}

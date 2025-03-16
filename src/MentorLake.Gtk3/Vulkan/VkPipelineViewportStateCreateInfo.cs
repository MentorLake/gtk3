namespace MentorLake.Vulkan;

public class VkPipelineViewportStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineViewportStateCreateInfoExtensions
{

	public static VkPipelineViewportStateCreateInfo Dereference(this VkPipelineViewportStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineViewportStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineViewportStateCreateInfoExterns
{
}

public struct VkPipelineViewportStateCreateInfo
{
}

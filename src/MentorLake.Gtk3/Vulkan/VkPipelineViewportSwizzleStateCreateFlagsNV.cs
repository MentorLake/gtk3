namespace MentorLake.Vulkan;

public class VkPipelineViewportSwizzleStateCreateFlagsNVHandle : BaseSafeHandle
{
}


public static class VkPipelineViewportSwizzleStateCreateFlagsNVExtensions
{

	public static VkPipelineViewportSwizzleStateCreateFlagsNV Dereference(this VkPipelineViewportSwizzleStateCreateFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineViewportSwizzleStateCreateFlagsNV>(x.DangerousGetHandle());
}
internal class VkPipelineViewportSwizzleStateCreateFlagsNVExterns
{
}

public struct VkPipelineViewportSwizzleStateCreateFlagsNV
{
}

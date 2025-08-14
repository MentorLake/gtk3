namespace MentorLake.Vulkan;


public class VkPipelineViewportSwizzleStateCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkPipelineViewportSwizzleStateCreateInfoNVExtensions
{

	public static VkPipelineViewportSwizzleStateCreateInfoNV Dereference(this VkPipelineViewportSwizzleStateCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineViewportSwizzleStateCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkPipelineViewportSwizzleStateCreateInfoNVExterns
{
}


public struct VkPipelineViewportSwizzleStateCreateInfoNV
{
}

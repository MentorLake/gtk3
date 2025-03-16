namespace MentorLake.Vulkan;

public class VkPipelineViewportWScalingStateCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkPipelineViewportWScalingStateCreateInfoNVExtensions
{

	public static VkPipelineViewportWScalingStateCreateInfoNV Dereference(this VkPipelineViewportWScalingStateCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineViewportWScalingStateCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkPipelineViewportWScalingStateCreateInfoNVExterns
{
}

public struct VkPipelineViewportWScalingStateCreateInfoNV
{
}

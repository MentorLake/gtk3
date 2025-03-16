namespace MentorLake.Vulkan;

public class VkPipelineViewportCoarseSampleOrderStateCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkPipelineViewportCoarseSampleOrderStateCreateInfoNVExtensions
{

	public static VkPipelineViewportCoarseSampleOrderStateCreateInfoNV Dereference(this VkPipelineViewportCoarseSampleOrderStateCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineViewportCoarseSampleOrderStateCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkPipelineViewportCoarseSampleOrderStateCreateInfoNVExterns
{
}

public struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
{
}

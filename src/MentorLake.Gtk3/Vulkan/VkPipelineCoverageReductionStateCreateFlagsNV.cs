namespace MentorLake.Vulkan;

public class VkPipelineCoverageReductionStateCreateFlagsNVHandle : BaseSafeHandle
{
}


public static class VkPipelineCoverageReductionStateCreateFlagsNVExtensions
{

	public static VkPipelineCoverageReductionStateCreateFlagsNV Dereference(this VkPipelineCoverageReductionStateCreateFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCoverageReductionStateCreateFlagsNV>(x.DangerousGetHandle());
}
internal class VkPipelineCoverageReductionStateCreateFlagsNVExterns
{
}

public struct VkPipelineCoverageReductionStateCreateFlagsNV
{
}

namespace MentorLake.Vulkan;

public class VkCoverageReductionModeNVHandle : BaseSafeHandle
{
}


public static class VkCoverageReductionModeNVExtensions
{

	public static VkCoverageReductionModeNV Dereference(this VkCoverageReductionModeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCoverageReductionModeNV>(x.DangerousGetHandle());
}
internal class VkCoverageReductionModeNVExterns
{
}

public struct VkCoverageReductionModeNV
{
}

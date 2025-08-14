namespace MentorLake.Vulkan;


public class VkPipelineCoverageReductionStateCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkPipelineCoverageReductionStateCreateInfoNVExtensions
{

	public static VkPipelineCoverageReductionStateCreateInfoNV Dereference(this VkPipelineCoverageReductionStateCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCoverageReductionStateCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkPipelineCoverageReductionStateCreateInfoNVExterns
{
}


public struct VkPipelineCoverageReductionStateCreateInfoNV
{
}

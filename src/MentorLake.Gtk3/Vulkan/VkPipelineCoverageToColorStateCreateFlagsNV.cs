namespace MentorLake.Vulkan;


public class VkPipelineCoverageToColorStateCreateFlagsNVHandle : BaseSafeHandle
{
}


public static class VkPipelineCoverageToColorStateCreateFlagsNVExtensions
{

	public static VkPipelineCoverageToColorStateCreateFlagsNV Dereference(this VkPipelineCoverageToColorStateCreateFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCoverageToColorStateCreateFlagsNV>(x.DangerousGetHandle());
}
internal class VkPipelineCoverageToColorStateCreateFlagsNVExterns
{
}


public struct VkPipelineCoverageToColorStateCreateFlagsNV
{
}

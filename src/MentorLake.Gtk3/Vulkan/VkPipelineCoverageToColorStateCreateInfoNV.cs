namespace MentorLake.Vulkan;

public class VkPipelineCoverageToColorStateCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkPipelineCoverageToColorStateCreateInfoNVExtensions
{

	public static VkPipelineCoverageToColorStateCreateInfoNV Dereference(this VkPipelineCoverageToColorStateCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCoverageToColorStateCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkPipelineCoverageToColorStateCreateInfoNVExterns
{
}

public struct VkPipelineCoverageToColorStateCreateInfoNV
{
}

namespace MentorLake.Vulkan;

public class VkPipelineCoverageModulationStateCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkPipelineCoverageModulationStateCreateInfoNVExtensions
{

	public static VkPipelineCoverageModulationStateCreateInfoNV Dereference(this VkPipelineCoverageModulationStateCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCoverageModulationStateCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkPipelineCoverageModulationStateCreateInfoNVExterns
{
}

public struct VkPipelineCoverageModulationStateCreateInfoNV
{
}

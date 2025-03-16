namespace MentorLake.Vulkan;

public class VkPipelineFragmentShadingRateStateCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineFragmentShadingRateStateCreateInfoKHRExtensions
{

	public static VkPipelineFragmentShadingRateStateCreateInfoKHR Dereference(this VkPipelineFragmentShadingRateStateCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineFragmentShadingRateStateCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkPipelineFragmentShadingRateStateCreateInfoKHRExterns
{
}

public struct VkPipelineFragmentShadingRateStateCreateInfoKHR
{
}

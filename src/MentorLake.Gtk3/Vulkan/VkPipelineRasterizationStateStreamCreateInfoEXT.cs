namespace MentorLake.Vulkan;

public class VkPipelineRasterizationStateStreamCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationStateStreamCreateInfoEXTExtensions
{

	public static VkPipelineRasterizationStateStreamCreateInfoEXT Dereference(this VkPipelineRasterizationStateStreamCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationStateStreamCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationStateStreamCreateInfoEXTExterns
{
}

public struct VkPipelineRasterizationStateStreamCreateInfoEXT
{
}

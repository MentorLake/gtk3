namespace MentorLake.Vulkan;

public class VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXTExtensions
{

	public static VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT Dereference(this VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXTExterns
{
}

public struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
{
}

namespace MentorLake.Vulkan;

public class VkPipelineShaderStageRequiredSubgroupSizeCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineShaderStageRequiredSubgroupSizeCreateInfoExtensions
{

	public static VkPipelineShaderStageRequiredSubgroupSizeCreateInfo Dereference(this VkPipelineShaderStageRequiredSubgroupSizeCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineShaderStageRequiredSubgroupSizeCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineShaderStageRequiredSubgroupSizeCreateInfoExterns
{
}

public struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
{
}

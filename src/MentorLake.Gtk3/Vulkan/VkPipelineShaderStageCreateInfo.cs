namespace MentorLake.Vulkan;


public class VkPipelineShaderStageCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineShaderStageCreateInfoExtensions
{

	public static VkPipelineShaderStageCreateInfo Dereference(this VkPipelineShaderStageCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineShaderStageCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineShaderStageCreateInfoExterns
{
}


public struct VkPipelineShaderStageCreateInfo
{
}

namespace MentorLake.Vulkan;


public class VkPipelineShaderStageCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkPipelineShaderStageCreateFlagBitsExtensions
{

	public static VkPipelineShaderStageCreateFlagBits Dereference(this VkPipelineShaderStageCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineShaderStageCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkPipelineShaderStageCreateFlagBitsExterns
{
}


public struct VkPipelineShaderStageCreateFlagBits
{
}

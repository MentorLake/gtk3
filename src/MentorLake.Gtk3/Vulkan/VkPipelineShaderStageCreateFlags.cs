namespace MentorLake.Vulkan;

public class VkPipelineShaderStageCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineShaderStageCreateFlagsExtensions
{

	public static VkPipelineShaderStageCreateFlags Dereference(this VkPipelineShaderStageCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineShaderStageCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineShaderStageCreateFlagsExterns
{
}

public struct VkPipelineShaderStageCreateFlags
{
}

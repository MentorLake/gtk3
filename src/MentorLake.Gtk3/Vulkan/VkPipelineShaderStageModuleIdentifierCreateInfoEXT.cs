namespace MentorLake.Vulkan;

public class VkPipelineShaderStageModuleIdentifierCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineShaderStageModuleIdentifierCreateInfoEXTExtensions
{

	public static VkPipelineShaderStageModuleIdentifierCreateInfoEXT Dereference(this VkPipelineShaderStageModuleIdentifierCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineShaderStageModuleIdentifierCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineShaderStageModuleIdentifierCreateInfoEXTExterns
{
}

public struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
{
}

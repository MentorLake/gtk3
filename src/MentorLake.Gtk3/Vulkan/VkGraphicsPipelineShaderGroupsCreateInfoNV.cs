namespace MentorLake.Vulkan;


public class VkGraphicsPipelineShaderGroupsCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkGraphicsPipelineShaderGroupsCreateInfoNVExtensions
{

	public static VkGraphicsPipelineShaderGroupsCreateInfoNV Dereference(this VkGraphicsPipelineShaderGroupsCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGraphicsPipelineShaderGroupsCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkGraphicsPipelineShaderGroupsCreateInfoNVExterns
{
}


public struct VkGraphicsPipelineShaderGroupsCreateInfoNV
{
}

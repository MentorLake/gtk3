namespace MentorLake.Vulkan;

public class VkGraphicsPipelineCreateInfoHandle : BaseSafeHandle
{
}


public static class VkGraphicsPipelineCreateInfoExtensions
{

	public static VkGraphicsPipelineCreateInfo Dereference(this VkGraphicsPipelineCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGraphicsPipelineCreateInfo>(x.DangerousGetHandle());
}
internal class VkGraphicsPipelineCreateInfoExterns
{
}

public struct VkGraphicsPipelineCreateInfo
{
}

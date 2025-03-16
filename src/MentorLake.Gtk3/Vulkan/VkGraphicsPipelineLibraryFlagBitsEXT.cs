namespace MentorLake.Vulkan;

public class VkGraphicsPipelineLibraryFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkGraphicsPipelineLibraryFlagBitsEXTExtensions
{

	public static VkGraphicsPipelineLibraryFlagBitsEXT Dereference(this VkGraphicsPipelineLibraryFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGraphicsPipelineLibraryFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkGraphicsPipelineLibraryFlagBitsEXTExterns
{
}

public struct VkGraphicsPipelineLibraryFlagBitsEXT
{
}

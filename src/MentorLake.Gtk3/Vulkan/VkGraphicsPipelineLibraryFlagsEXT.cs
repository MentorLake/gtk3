namespace MentorLake.Vulkan;

public class VkGraphicsPipelineLibraryFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkGraphicsPipelineLibraryFlagsEXTExtensions
{

	public static VkGraphicsPipelineLibraryFlagsEXT Dereference(this VkGraphicsPipelineLibraryFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGraphicsPipelineLibraryFlagsEXT>(x.DangerousGetHandle());
}
internal class VkGraphicsPipelineLibraryFlagsEXTExterns
{
}

public struct VkGraphicsPipelineLibraryFlagsEXT
{
}

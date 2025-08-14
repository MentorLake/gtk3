namespace MentorLake.Vulkan;


public class VkGraphicsPipelineLibraryCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkGraphicsPipelineLibraryCreateInfoEXTExtensions
{

	public static VkGraphicsPipelineLibraryCreateInfoEXT Dereference(this VkGraphicsPipelineLibraryCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGraphicsPipelineLibraryCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkGraphicsPipelineLibraryCreateInfoEXTExterns
{
}


public struct VkGraphicsPipelineLibraryCreateInfoEXT
{
}

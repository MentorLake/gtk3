namespace MentorLake.Vulkan;


public class VkPipelineRasterizationDepthClipStateCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationDepthClipStateCreateInfoEXTExtensions
{

	public static VkPipelineRasterizationDepthClipStateCreateInfoEXT Dereference(this VkPipelineRasterizationDepthClipStateCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationDepthClipStateCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationDepthClipStateCreateInfoEXTExterns
{
}


public struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
{
}

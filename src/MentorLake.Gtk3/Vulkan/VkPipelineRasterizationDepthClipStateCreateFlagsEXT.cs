namespace MentorLake.Vulkan;

public class VkPipelineRasterizationDepthClipStateCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationDepthClipStateCreateFlagsEXTExtensions
{

	public static VkPipelineRasterizationDepthClipStateCreateFlagsEXT Dereference(this VkPipelineRasterizationDepthClipStateCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationDepthClipStateCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationDepthClipStateCreateFlagsEXTExterns
{
}

public struct VkPipelineRasterizationDepthClipStateCreateFlagsEXT
{
}

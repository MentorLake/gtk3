namespace MentorLake.Vulkan;


public class VkPipelineDiscardRectangleStateCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineDiscardRectangleStateCreateFlagsEXTExtensions
{

	public static VkPipelineDiscardRectangleStateCreateFlagsEXT Dereference(this VkPipelineDiscardRectangleStateCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineDiscardRectangleStateCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkPipelineDiscardRectangleStateCreateFlagsEXTExterns
{
}


public struct VkPipelineDiscardRectangleStateCreateFlagsEXT
{
}

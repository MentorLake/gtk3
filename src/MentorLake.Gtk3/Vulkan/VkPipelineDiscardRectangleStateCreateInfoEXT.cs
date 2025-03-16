namespace MentorLake.Vulkan;

public class VkPipelineDiscardRectangleStateCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineDiscardRectangleStateCreateInfoEXTExtensions
{

	public static VkPipelineDiscardRectangleStateCreateInfoEXT Dereference(this VkPipelineDiscardRectangleStateCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineDiscardRectangleStateCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineDiscardRectangleStateCreateInfoEXTExterns
{
}

public struct VkPipelineDiscardRectangleStateCreateInfoEXT
{
}

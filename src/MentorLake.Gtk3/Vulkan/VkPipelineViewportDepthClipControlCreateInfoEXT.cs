namespace MentorLake.Vulkan;

public class VkPipelineViewportDepthClipControlCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineViewportDepthClipControlCreateInfoEXTExtensions
{

	public static VkPipelineViewportDepthClipControlCreateInfoEXT Dereference(this VkPipelineViewportDepthClipControlCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineViewportDepthClipControlCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineViewportDepthClipControlCreateInfoEXTExterns
{
}

public struct VkPipelineViewportDepthClipControlCreateInfoEXT
{
}

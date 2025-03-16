namespace MentorLake.Vulkan;

public class VkRenderPassSubpassFeedbackInfoEXTHandle : BaseSafeHandle
{
}


public static class VkRenderPassSubpassFeedbackInfoEXTExtensions
{

	public static VkRenderPassSubpassFeedbackInfoEXT Dereference(this VkRenderPassSubpassFeedbackInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassSubpassFeedbackInfoEXT>(x.DangerousGetHandle());
}
internal class VkRenderPassSubpassFeedbackInfoEXTExterns
{
}

public struct VkRenderPassSubpassFeedbackInfoEXT
{
}

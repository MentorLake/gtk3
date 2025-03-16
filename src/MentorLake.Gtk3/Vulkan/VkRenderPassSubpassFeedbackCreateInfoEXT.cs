namespace MentorLake.Vulkan;

public class VkRenderPassSubpassFeedbackCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkRenderPassSubpassFeedbackCreateInfoEXTExtensions
{

	public static VkRenderPassSubpassFeedbackCreateInfoEXT Dereference(this VkRenderPassSubpassFeedbackCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassSubpassFeedbackCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkRenderPassSubpassFeedbackCreateInfoEXTExterns
{
}

public struct VkRenderPassSubpassFeedbackCreateInfoEXT
{
}

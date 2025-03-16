namespace MentorLake.Vulkan;

public class VkRenderPassCreationFeedbackCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkRenderPassCreationFeedbackCreateInfoEXTExtensions
{

	public static VkRenderPassCreationFeedbackCreateInfoEXT Dereference(this VkRenderPassCreationFeedbackCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassCreationFeedbackCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkRenderPassCreationFeedbackCreateInfoEXTExterns
{
}

public struct VkRenderPassCreationFeedbackCreateInfoEXT
{
}

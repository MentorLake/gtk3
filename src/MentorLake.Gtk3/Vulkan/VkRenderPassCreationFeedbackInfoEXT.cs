namespace MentorLake.Vulkan;

public class VkRenderPassCreationFeedbackInfoEXTHandle : BaseSafeHandle
{
}


public static class VkRenderPassCreationFeedbackInfoEXTExtensions
{

	public static VkRenderPassCreationFeedbackInfoEXT Dereference(this VkRenderPassCreationFeedbackInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassCreationFeedbackInfoEXT>(x.DangerousGetHandle());
}
internal class VkRenderPassCreationFeedbackInfoEXTExterns
{
}

public struct VkRenderPassCreationFeedbackInfoEXT
{
}

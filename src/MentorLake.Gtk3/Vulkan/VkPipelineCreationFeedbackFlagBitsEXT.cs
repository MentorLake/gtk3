namespace MentorLake.Vulkan;

public class VkPipelineCreationFeedbackFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineCreationFeedbackFlagBitsEXTExtensions
{

	public static VkPipelineCreationFeedbackFlagBitsEXT Dereference(this VkPipelineCreationFeedbackFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreationFeedbackFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkPipelineCreationFeedbackFlagBitsEXTExterns
{
}

public struct VkPipelineCreationFeedbackFlagBitsEXT
{
}

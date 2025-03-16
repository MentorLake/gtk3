namespace MentorLake.Vulkan;

public class VkPipelineCreationFeedbackEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineCreationFeedbackEXTExtensions
{

	public static VkPipelineCreationFeedbackEXT Dereference(this VkPipelineCreationFeedbackEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreationFeedbackEXT>(x.DangerousGetHandle());
}
internal class VkPipelineCreationFeedbackEXTExterns
{
}

public struct VkPipelineCreationFeedbackEXT
{
}

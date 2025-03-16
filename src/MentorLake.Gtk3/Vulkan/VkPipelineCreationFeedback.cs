namespace MentorLake.Vulkan;

public class VkPipelineCreationFeedbackHandle : BaseSafeHandle
{
}


public static class VkPipelineCreationFeedbackExtensions
{

	public static VkPipelineCreationFeedback Dereference(this VkPipelineCreationFeedbackHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreationFeedback>(x.DangerousGetHandle());
}
internal class VkPipelineCreationFeedbackExterns
{
}

public struct VkPipelineCreationFeedback
{
}

namespace MentorLake.Vulkan;

public class VkPipelineCreationFeedbackFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineCreationFeedbackFlagsExtensions
{

	public static VkPipelineCreationFeedbackFlags Dereference(this VkPipelineCreationFeedbackFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreationFeedbackFlags>(x.DangerousGetHandle());
}
internal class VkPipelineCreationFeedbackFlagsExterns
{
}

public struct VkPipelineCreationFeedbackFlags
{
}

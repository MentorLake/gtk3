namespace MentorLake.Vulkan;


public class VkPipelineCreationFeedbackFlagBitsHandle : BaseSafeHandle
{
}


public static class VkPipelineCreationFeedbackFlagBitsExtensions
{

	public static VkPipelineCreationFeedbackFlagBits Dereference(this VkPipelineCreationFeedbackFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreationFeedbackFlagBits>(x.DangerousGetHandle());
}
internal class VkPipelineCreationFeedbackFlagBitsExterns
{
}


public struct VkPipelineCreationFeedbackFlagBits
{
}

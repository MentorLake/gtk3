namespace MentorLake.Vulkan;


public class VkPipelineCreationFeedbackFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineCreationFeedbackFlagsEXTExtensions
{

	public static VkPipelineCreationFeedbackFlagsEXT Dereference(this VkPipelineCreationFeedbackFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreationFeedbackFlagsEXT>(x.DangerousGetHandle());
}
internal class VkPipelineCreationFeedbackFlagsEXTExterns
{
}


public struct VkPipelineCreationFeedbackFlagsEXT
{
}

namespace MentorLake.Vulkan;


public class VkPipelineCreationFeedbackCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineCreationFeedbackCreateInfoEXTExtensions
{

	public static VkPipelineCreationFeedbackCreateInfoEXT Dereference(this VkPipelineCreationFeedbackCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreationFeedbackCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineCreationFeedbackCreateInfoEXTExterns
{
}


public struct VkPipelineCreationFeedbackCreateInfoEXT
{
}

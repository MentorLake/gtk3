namespace MentorLake.Vulkan;


public class VkPipelineCreationFeedbackCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineCreationFeedbackCreateInfoExtensions
{

	public static VkPipelineCreationFeedbackCreateInfo Dereference(this VkPipelineCreationFeedbackCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreationFeedbackCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineCreationFeedbackCreateInfoExterns
{
}


public struct VkPipelineCreationFeedbackCreateInfo
{
}

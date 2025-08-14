namespace MentorLake.Vulkan;


public class VkPipelineColorBlendAttachmentStateHandle : BaseSafeHandle
{
}


public static class VkPipelineColorBlendAttachmentStateExtensions
{

	public static VkPipelineColorBlendAttachmentState Dereference(this VkPipelineColorBlendAttachmentStateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineColorBlendAttachmentState>(x.DangerousGetHandle());
}
internal class VkPipelineColorBlendAttachmentStateExterns
{
}


public struct VkPipelineColorBlendAttachmentState
{
}

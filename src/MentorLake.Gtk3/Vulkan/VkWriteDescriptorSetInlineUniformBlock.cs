namespace MentorLake.Vulkan;


public class VkWriteDescriptorSetInlineUniformBlockHandle : BaseSafeHandle
{
}


public static class VkWriteDescriptorSetInlineUniformBlockExtensions
{

	public static VkWriteDescriptorSetInlineUniformBlock Dereference(this VkWriteDescriptorSetInlineUniformBlockHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkWriteDescriptorSetInlineUniformBlock>(x.DangerousGetHandle());
}
internal class VkWriteDescriptorSetInlineUniformBlockExterns
{
}


public struct VkWriteDescriptorSetInlineUniformBlock
{
}

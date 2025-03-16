namespace MentorLake.Vulkan;

public class VkWriteDescriptorSetInlineUniformBlockEXTHandle : BaseSafeHandle
{
}


public static class VkWriteDescriptorSetInlineUniformBlockEXTExtensions
{

	public static VkWriteDescriptorSetInlineUniformBlockEXT Dereference(this VkWriteDescriptorSetInlineUniformBlockEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkWriteDescriptorSetInlineUniformBlockEXT>(x.DangerousGetHandle());
}
internal class VkWriteDescriptorSetInlineUniformBlockEXTExterns
{
}

public struct VkWriteDescriptorSetInlineUniformBlockEXT
{
}

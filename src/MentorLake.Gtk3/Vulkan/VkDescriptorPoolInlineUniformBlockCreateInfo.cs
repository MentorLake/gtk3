namespace MentorLake.Vulkan;


public class VkDescriptorPoolInlineUniformBlockCreateInfoHandle : BaseSafeHandle
{
}


public static class VkDescriptorPoolInlineUniformBlockCreateInfoExtensions
{

	public static VkDescriptorPoolInlineUniformBlockCreateInfo Dereference(this VkDescriptorPoolInlineUniformBlockCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorPoolInlineUniformBlockCreateInfo>(x.DangerousGetHandle());
}
internal class VkDescriptorPoolInlineUniformBlockCreateInfoExterns
{
}


public struct VkDescriptorPoolInlineUniformBlockCreateInfo
{
}

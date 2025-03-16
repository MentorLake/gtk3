namespace MentorLake.Vulkan;

public class VkDescriptorPoolInlineUniformBlockCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorPoolInlineUniformBlockCreateInfoEXTExtensions
{

	public static VkDescriptorPoolInlineUniformBlockCreateInfoEXT Dereference(this VkDescriptorPoolInlineUniformBlockCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorPoolInlineUniformBlockCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorPoolInlineUniformBlockCreateInfoEXTExterns
{
}

public struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
{
}

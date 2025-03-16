namespace MentorLake.Vulkan;

public class VkPhysicalDeviceInlineUniformBlockFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceInlineUniformBlockFeaturesEXTExtensions
{

	public static VkPhysicalDeviceInlineUniformBlockFeaturesEXT Dereference(this VkPhysicalDeviceInlineUniformBlockFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceInlineUniformBlockFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceInlineUniformBlockFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
{
}

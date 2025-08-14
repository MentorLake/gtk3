namespace MentorLake.Vulkan;


public class VkPhysicalDeviceInlineUniformBlockFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceInlineUniformBlockFeaturesExtensions
{

	public static VkPhysicalDeviceInlineUniformBlockFeatures Dereference(this VkPhysicalDeviceInlineUniformBlockFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceInlineUniformBlockFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceInlineUniformBlockFeaturesExterns
{
}


public struct VkPhysicalDeviceInlineUniformBlockFeatures
{
}

namespace MentorLake.Vulkan;


public class VkPhysicalDeviceInlineUniformBlockPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceInlineUniformBlockPropertiesEXTExtensions
{

	public static VkPhysicalDeviceInlineUniformBlockPropertiesEXT Dereference(this VkPhysicalDeviceInlineUniformBlockPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceInlineUniformBlockPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceInlineUniformBlockPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
{
}

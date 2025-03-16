namespace MentorLake.Vulkan;

public class VkPhysicalDeviceInlineUniformBlockPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceInlineUniformBlockPropertiesExtensions
{

	public static VkPhysicalDeviceInlineUniformBlockProperties Dereference(this VkPhysicalDeviceInlineUniformBlockPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceInlineUniformBlockProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceInlineUniformBlockPropertiesExterns
{
}

public struct VkPhysicalDeviceInlineUniformBlockProperties
{
}

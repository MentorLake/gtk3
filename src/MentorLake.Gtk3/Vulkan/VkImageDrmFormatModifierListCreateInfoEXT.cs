namespace MentorLake.Vulkan;


public class VkImageDrmFormatModifierListCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkImageDrmFormatModifierListCreateInfoEXTExtensions
{

	public static VkImageDrmFormatModifierListCreateInfoEXT Dereference(this VkImageDrmFormatModifierListCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageDrmFormatModifierListCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkImageDrmFormatModifierListCreateInfoEXTExterns
{
}


public struct VkImageDrmFormatModifierListCreateInfoEXT
{
}

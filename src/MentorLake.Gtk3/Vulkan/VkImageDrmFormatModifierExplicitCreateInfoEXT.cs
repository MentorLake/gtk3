namespace MentorLake.Vulkan;

public class VkImageDrmFormatModifierExplicitCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkImageDrmFormatModifierExplicitCreateInfoEXTExtensions
{

	public static VkImageDrmFormatModifierExplicitCreateInfoEXT Dereference(this VkImageDrmFormatModifierExplicitCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageDrmFormatModifierExplicitCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkImageDrmFormatModifierExplicitCreateInfoEXTExterns
{
}

public struct VkImageDrmFormatModifierExplicitCreateInfoEXT
{
}

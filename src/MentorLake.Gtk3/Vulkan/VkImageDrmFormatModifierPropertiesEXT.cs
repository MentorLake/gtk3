namespace MentorLake.Vulkan;

public class VkImageDrmFormatModifierPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkImageDrmFormatModifierPropertiesEXTExtensions
{

	public static VkImageDrmFormatModifierPropertiesEXT Dereference(this VkImageDrmFormatModifierPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageDrmFormatModifierPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkImageDrmFormatModifierPropertiesEXTExterns
{
}

public struct VkImageDrmFormatModifierPropertiesEXT
{
}

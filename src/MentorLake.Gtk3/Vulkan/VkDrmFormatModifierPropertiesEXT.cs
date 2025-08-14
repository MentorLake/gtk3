namespace MentorLake.Vulkan;


public class VkDrmFormatModifierPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkDrmFormatModifierPropertiesEXTExtensions
{

	public static VkDrmFormatModifierPropertiesEXT Dereference(this VkDrmFormatModifierPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDrmFormatModifierPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkDrmFormatModifierPropertiesEXTExterns
{
}


public struct VkDrmFormatModifierPropertiesEXT
{
}

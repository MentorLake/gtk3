namespace MentorLake.Vulkan;


public class VkDrmFormatModifierPropertiesList2EXTHandle : BaseSafeHandle
{
}


public static class VkDrmFormatModifierPropertiesList2EXTExtensions
{

	public static VkDrmFormatModifierPropertiesList2EXT Dereference(this VkDrmFormatModifierPropertiesList2EXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDrmFormatModifierPropertiesList2EXT>(x.DangerousGetHandle());
}
internal class VkDrmFormatModifierPropertiesList2EXTExterns
{
}


public struct VkDrmFormatModifierPropertiesList2EXT
{
}

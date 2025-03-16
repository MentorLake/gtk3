namespace MentorLake.Vulkan;

public class VkDrmFormatModifierPropertiesListEXTHandle : BaseSafeHandle
{
}


public static class VkDrmFormatModifierPropertiesListEXTExtensions
{

	public static VkDrmFormatModifierPropertiesListEXT Dereference(this VkDrmFormatModifierPropertiesListEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDrmFormatModifierPropertiesListEXT>(x.DangerousGetHandle());
}
internal class VkDrmFormatModifierPropertiesListEXTExterns
{
}

public struct VkDrmFormatModifierPropertiesListEXT
{
}

namespace MentorLake.Vulkan;

public class VkExternalImageFormatPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkExternalImageFormatPropertiesNVExtensions
{

	public static VkExternalImageFormatPropertiesNV Dereference(this VkExternalImageFormatPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalImageFormatPropertiesNV>(x.DangerousGetHandle());
}
internal class VkExternalImageFormatPropertiesNVExterns
{
}

public struct VkExternalImageFormatPropertiesNV
{
}

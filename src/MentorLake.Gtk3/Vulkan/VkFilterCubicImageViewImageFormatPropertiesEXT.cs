namespace MentorLake.Vulkan;

public class VkFilterCubicImageViewImageFormatPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkFilterCubicImageViewImageFormatPropertiesEXTExtensions
{

	public static VkFilterCubicImageViewImageFormatPropertiesEXT Dereference(this VkFilterCubicImageViewImageFormatPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFilterCubicImageViewImageFormatPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkFilterCubicImageViewImageFormatPropertiesEXTExterns
{
}

public struct VkFilterCubicImageViewImageFormatPropertiesEXT
{
}

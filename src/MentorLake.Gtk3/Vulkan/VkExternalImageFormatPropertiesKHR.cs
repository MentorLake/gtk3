namespace MentorLake.Vulkan;

public class VkExternalImageFormatPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkExternalImageFormatPropertiesKHRExtensions
{

	public static VkExternalImageFormatPropertiesKHR Dereference(this VkExternalImageFormatPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalImageFormatPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkExternalImageFormatPropertiesKHRExterns
{
}

public struct VkExternalImageFormatPropertiesKHR
{
}

namespace MentorLake.Vulkan;


public class VkSamplerYcbcrConversionImageFormatPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrConversionImageFormatPropertiesKHRExtensions
{

	public static VkSamplerYcbcrConversionImageFormatPropertiesKHR Dereference(this VkSamplerYcbcrConversionImageFormatPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrConversionImageFormatPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrConversionImageFormatPropertiesKHRExterns
{
}


public struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
{
}

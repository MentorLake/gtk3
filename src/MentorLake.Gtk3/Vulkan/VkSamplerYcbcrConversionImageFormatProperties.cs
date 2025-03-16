namespace MentorLake.Vulkan;

public class VkSamplerYcbcrConversionImageFormatPropertiesHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrConversionImageFormatPropertiesExtensions
{

	public static VkSamplerYcbcrConversionImageFormatProperties Dereference(this VkSamplerYcbcrConversionImageFormatPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrConversionImageFormatProperties>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrConversionImageFormatPropertiesExterns
{
}

public struct VkSamplerYcbcrConversionImageFormatProperties
{
}

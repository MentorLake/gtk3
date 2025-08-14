namespace MentorLake.Vulkan;


public class VkSamplerYcbcrConversionKHRHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrConversionKHRExtensions
{

	public static VkSamplerYcbcrConversionKHR Dereference(this VkSamplerYcbcrConversionKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrConversionKHR>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrConversionKHRExterns
{
}


public struct VkSamplerYcbcrConversionKHR
{
}

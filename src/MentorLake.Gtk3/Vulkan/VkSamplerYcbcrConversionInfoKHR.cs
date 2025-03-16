namespace MentorLake.Vulkan;

public class VkSamplerYcbcrConversionInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrConversionInfoKHRExtensions
{

	public static VkSamplerYcbcrConversionInfoKHR Dereference(this VkSamplerYcbcrConversionInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrConversionInfoKHR>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrConversionInfoKHRExterns
{
}

public struct VkSamplerYcbcrConversionInfoKHR
{
}

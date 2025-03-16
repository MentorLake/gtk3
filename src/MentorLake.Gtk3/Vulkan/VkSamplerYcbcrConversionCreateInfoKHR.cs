namespace MentorLake.Vulkan;

public class VkSamplerYcbcrConversionCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrConversionCreateInfoKHRExtensions
{

	public static VkSamplerYcbcrConversionCreateInfoKHR Dereference(this VkSamplerYcbcrConversionCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrConversionCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrConversionCreateInfoKHRExterns
{
}

public struct VkSamplerYcbcrConversionCreateInfoKHR
{
}

namespace MentorLake.Vulkan;

public class VkSamplerYcbcrConversionCreateInfoHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrConversionCreateInfoExtensions
{

	public static VkSamplerYcbcrConversionCreateInfo Dereference(this VkSamplerYcbcrConversionCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrConversionCreateInfo>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrConversionCreateInfoExterns
{
}

public struct VkSamplerYcbcrConversionCreateInfo
{
}

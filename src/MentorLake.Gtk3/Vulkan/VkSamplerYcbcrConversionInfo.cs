namespace MentorLake.Vulkan;


public class VkSamplerYcbcrConversionInfoHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrConversionInfoExtensions
{

	public static VkSamplerYcbcrConversionInfo Dereference(this VkSamplerYcbcrConversionInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrConversionInfo>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrConversionInfoExterns
{
}


public struct VkSamplerYcbcrConversionInfo
{
}

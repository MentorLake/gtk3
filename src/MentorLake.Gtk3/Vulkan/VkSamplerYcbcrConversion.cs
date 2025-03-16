namespace MentorLake.Vulkan;

public class VkSamplerYcbcrConversionHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrConversionExtensions
{

	public static VkSamplerYcbcrConversion Dereference(this VkSamplerYcbcrConversionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrConversion>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrConversionExterns
{
}

public struct VkSamplerYcbcrConversion
{
}

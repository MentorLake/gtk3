namespace MentorLake.Vulkan;

public class VkSamplerYcbcrModelConversionKHRHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrModelConversionKHRExtensions
{

	public static VkSamplerYcbcrModelConversionKHR Dereference(this VkSamplerYcbcrModelConversionKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrModelConversionKHR>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrModelConversionKHRExterns
{
}

public struct VkSamplerYcbcrModelConversionKHR
{
}

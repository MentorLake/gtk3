namespace MentorLake.Vulkan;

public class VkSamplerYcbcrModelConversionHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrModelConversionExtensions
{

	public static VkSamplerYcbcrModelConversion Dereference(this VkSamplerYcbcrModelConversionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrModelConversion>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrModelConversionExterns
{
}

public struct VkSamplerYcbcrModelConversion
{
}

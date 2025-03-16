namespace MentorLake.Vulkan;

public class VkSamplerMipmapModeHandle : BaseSafeHandle
{
}


public static class VkSamplerMipmapModeExtensions
{

	public static VkSamplerMipmapMode Dereference(this VkSamplerMipmapModeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerMipmapMode>(x.DangerousGetHandle());
}
internal class VkSamplerMipmapModeExterns
{
}

public struct VkSamplerMipmapMode
{
}

namespace MentorLake.Vulkan;

public class VkSamplerCreateInfoHandle : BaseSafeHandle
{
}


public static class VkSamplerCreateInfoExtensions
{

	public static VkSamplerCreateInfo Dereference(this VkSamplerCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerCreateInfo>(x.DangerousGetHandle());
}
internal class VkSamplerCreateInfoExterns
{
}

public struct VkSamplerCreateInfo
{
}

namespace MentorLake.Vulkan;

public class VkSamplerCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkSamplerCreateFlagBitsExtensions
{

	public static VkSamplerCreateFlagBits Dereference(this VkSamplerCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkSamplerCreateFlagBitsExterns
{
}

public struct VkSamplerCreateFlagBits
{
}

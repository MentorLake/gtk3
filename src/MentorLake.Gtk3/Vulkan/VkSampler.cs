namespace MentorLake.Vulkan;

public class VkSamplerHandle : BaseSafeHandle
{
}


public static class VkSamplerExtensions
{

	public static VkSampler Dereference(this VkSamplerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSampler>(x.DangerousGetHandle());
}
internal class VkSamplerExterns
{
}

public struct VkSampler
{
}

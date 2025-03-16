namespace MentorLake.Vulkan;

public class VkSamplerCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkSamplerCreateFlagsExtensions
{

	public static VkSamplerCreateFlags Dereference(this VkSamplerCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerCreateFlags>(x.DangerousGetHandle());
}
internal class VkSamplerCreateFlagsExterns
{
}

public struct VkSamplerCreateFlags
{
}

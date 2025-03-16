namespace MentorLake.Vulkan;

public class VkSamplerReductionModeCreateInfoHandle : BaseSafeHandle
{
}


public static class VkSamplerReductionModeCreateInfoExtensions
{

	public static VkSamplerReductionModeCreateInfo Dereference(this VkSamplerReductionModeCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerReductionModeCreateInfo>(x.DangerousGetHandle());
}
internal class VkSamplerReductionModeCreateInfoExterns
{
}

public struct VkSamplerReductionModeCreateInfo
{
}

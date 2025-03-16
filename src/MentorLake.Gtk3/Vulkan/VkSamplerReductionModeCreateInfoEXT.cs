namespace MentorLake.Vulkan;

public class VkSamplerReductionModeCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSamplerReductionModeCreateInfoEXTExtensions
{

	public static VkSamplerReductionModeCreateInfoEXT Dereference(this VkSamplerReductionModeCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerReductionModeCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkSamplerReductionModeCreateInfoEXTExterns
{
}

public struct VkSamplerReductionModeCreateInfoEXT
{
}

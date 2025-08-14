namespace MentorLake.Vulkan;


public class VkSamplerReductionModeEXTHandle : BaseSafeHandle
{
}


public static class VkSamplerReductionModeEXTExtensions
{

	public static VkSamplerReductionModeEXT Dereference(this VkSamplerReductionModeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerReductionModeEXT>(x.DangerousGetHandle());
}
internal class VkSamplerReductionModeEXTExterns
{
}


public struct VkSamplerReductionModeEXT
{
}

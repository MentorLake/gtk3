namespace MentorLake.Vulkan;


public class VkSamplerReductionModeHandle : BaseSafeHandle
{
}


public static class VkSamplerReductionModeExtensions
{

	public static VkSamplerReductionMode Dereference(this VkSamplerReductionModeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerReductionMode>(x.DangerousGetHandle());
}
internal class VkSamplerReductionModeExterns
{
}


public struct VkSamplerReductionMode
{
}

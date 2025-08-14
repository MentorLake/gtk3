namespace MentorLake.Vulkan;


public class VkSamplerYcbcrRangeHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrRangeExtensions
{

	public static VkSamplerYcbcrRange Dereference(this VkSamplerYcbcrRangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrRange>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrRangeExterns
{
}


public struct VkSamplerYcbcrRange
{
}

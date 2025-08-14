namespace MentorLake.Vulkan;


public class VkSamplerYcbcrRangeKHRHandle : BaseSafeHandle
{
}


public static class VkSamplerYcbcrRangeKHRExtensions
{

	public static VkSamplerYcbcrRangeKHR Dereference(this VkSamplerYcbcrRangeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerYcbcrRangeKHR>(x.DangerousGetHandle());
}
internal class VkSamplerYcbcrRangeKHRExterns
{
}


public struct VkSamplerYcbcrRangeKHR
{
}

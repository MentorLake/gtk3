namespace MentorLake.Vulkan;

public class VkVideoDecodeUsageInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeUsageInfoKHRExtensions
{

	public static VkVideoDecodeUsageInfoKHR Dereference(this VkVideoDecodeUsageInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeUsageInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeUsageInfoKHRExterns
{
}

public struct VkVideoDecodeUsageInfoKHR
{
}

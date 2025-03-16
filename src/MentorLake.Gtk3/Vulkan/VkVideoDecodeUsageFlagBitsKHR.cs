namespace MentorLake.Vulkan;

public class VkVideoDecodeUsageFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeUsageFlagBitsKHRExtensions
{

	public static VkVideoDecodeUsageFlagBitsKHR Dereference(this VkVideoDecodeUsageFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeUsageFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeUsageFlagBitsKHRExterns
{
}

public struct VkVideoDecodeUsageFlagBitsKHR
{
}

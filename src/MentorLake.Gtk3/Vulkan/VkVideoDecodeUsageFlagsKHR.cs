namespace MentorLake.Vulkan;

public class VkVideoDecodeUsageFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeUsageFlagsKHRExtensions
{

	public static VkVideoDecodeUsageFlagsKHR Dereference(this VkVideoDecodeUsageFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeUsageFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeUsageFlagsKHRExterns
{
}

public struct VkVideoDecodeUsageFlagsKHR
{
}

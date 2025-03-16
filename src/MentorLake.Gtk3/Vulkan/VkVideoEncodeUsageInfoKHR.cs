namespace MentorLake.Vulkan;

public class VkVideoEncodeUsageInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeUsageInfoKHRExtensions
{

	public static VkVideoEncodeUsageInfoKHR Dereference(this VkVideoEncodeUsageInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeUsageInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeUsageInfoKHRExterns
{
}

public struct VkVideoEncodeUsageInfoKHR
{
}

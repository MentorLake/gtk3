namespace MentorLake.Vulkan;

public class VkVideoEncodeRateControlModeFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeRateControlModeFlagsKHRExtensions
{

	public static VkVideoEncodeRateControlModeFlagsKHR Dereference(this VkVideoEncodeRateControlModeFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeRateControlModeFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeRateControlModeFlagsKHRExterns
{
}

public struct VkVideoEncodeRateControlModeFlagsKHR
{
}

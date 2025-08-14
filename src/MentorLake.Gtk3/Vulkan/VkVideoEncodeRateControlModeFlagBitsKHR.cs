namespace MentorLake.Vulkan;


public class VkVideoEncodeRateControlModeFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeRateControlModeFlagBitsKHRExtensions
{

	public static VkVideoEncodeRateControlModeFlagBitsKHR Dereference(this VkVideoEncodeRateControlModeFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeRateControlModeFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeRateControlModeFlagBitsKHRExterns
{
}


public struct VkVideoEncodeRateControlModeFlagBitsKHR
{
}

namespace MentorLake.Vulkan;

public class VkVideoEncodeH264RateControlInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264RateControlInfoKHRExtensions
{

	public static VkVideoEncodeH264RateControlInfoKHR Dereference(this VkVideoEncodeH264RateControlInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264RateControlInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264RateControlInfoKHRExterns
{
}

public struct VkVideoEncodeH264RateControlInfoKHR
{
}

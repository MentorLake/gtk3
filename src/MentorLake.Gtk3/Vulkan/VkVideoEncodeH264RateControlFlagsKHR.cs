namespace MentorLake.Vulkan;

public class VkVideoEncodeH264RateControlFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264RateControlFlagsKHRExtensions
{

	public static VkVideoEncodeH264RateControlFlagsKHR Dereference(this VkVideoEncodeH264RateControlFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264RateControlFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264RateControlFlagsKHRExterns
{
}

public struct VkVideoEncodeH264RateControlFlagsKHR
{
}

namespace MentorLake.Vulkan;


public class VkVideoEncodeRateControlFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeRateControlFlagsKHRExtensions
{

	public static VkVideoEncodeRateControlFlagsKHR Dereference(this VkVideoEncodeRateControlFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeRateControlFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeRateControlFlagsKHRExterns
{
}


public struct VkVideoEncodeRateControlFlagsKHR
{
}

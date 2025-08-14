namespace MentorLake.Vulkan;


public class VkVideoEncodeRateControlInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeRateControlInfoKHRExtensions
{

	public static VkVideoEncodeRateControlInfoKHR Dereference(this VkVideoEncodeRateControlInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeRateControlInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeRateControlInfoKHRExterns
{
}


public struct VkVideoEncodeRateControlInfoKHR
{
}

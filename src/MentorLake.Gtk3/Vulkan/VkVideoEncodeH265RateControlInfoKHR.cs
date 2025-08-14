namespace MentorLake.Vulkan;


public class VkVideoEncodeH265RateControlInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265RateControlInfoKHRExtensions
{

	public static VkVideoEncodeH265RateControlInfoKHR Dereference(this VkVideoEncodeH265RateControlInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265RateControlInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265RateControlInfoKHRExterns
{
}


public struct VkVideoEncodeH265RateControlInfoKHR
{
}

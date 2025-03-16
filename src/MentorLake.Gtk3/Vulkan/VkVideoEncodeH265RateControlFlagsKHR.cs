namespace MentorLake.Vulkan;

public class VkVideoEncodeH265RateControlFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265RateControlFlagsKHRExtensions
{

	public static VkVideoEncodeH265RateControlFlagsKHR Dereference(this VkVideoEncodeH265RateControlFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265RateControlFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265RateControlFlagsKHRExterns
{
}

public struct VkVideoEncodeH265RateControlFlagsKHR
{
}

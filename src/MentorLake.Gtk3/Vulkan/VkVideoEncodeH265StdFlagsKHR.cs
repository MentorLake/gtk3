namespace MentorLake.Vulkan;


public class VkVideoEncodeH265StdFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265StdFlagsKHRExtensions
{

	public static VkVideoEncodeH265StdFlagsKHR Dereference(this VkVideoEncodeH265StdFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265StdFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265StdFlagsKHRExterns
{
}


public struct VkVideoEncodeH265StdFlagsKHR
{
}

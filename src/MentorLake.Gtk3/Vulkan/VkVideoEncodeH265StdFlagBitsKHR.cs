namespace MentorLake.Vulkan;

public class VkVideoEncodeH265StdFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265StdFlagBitsKHRExtensions
{

	public static VkVideoEncodeH265StdFlagBitsKHR Dereference(this VkVideoEncodeH265StdFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265StdFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265StdFlagBitsKHRExterns
{
}

public struct VkVideoEncodeH265StdFlagBitsKHR
{
}

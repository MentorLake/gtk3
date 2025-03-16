namespace MentorLake.Vulkan;

public class VkVideoEncodeH265FrameSizeKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265FrameSizeKHRExtensions
{

	public static VkVideoEncodeH265FrameSizeKHR Dereference(this VkVideoEncodeH265FrameSizeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265FrameSizeKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265FrameSizeKHRExterns
{
}

public struct VkVideoEncodeH265FrameSizeKHR
{
}

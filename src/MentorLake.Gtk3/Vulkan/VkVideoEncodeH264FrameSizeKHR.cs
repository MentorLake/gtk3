namespace MentorLake.Vulkan;


public class VkVideoEncodeH264FrameSizeKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264FrameSizeKHRExtensions
{

	public static VkVideoEncodeH264FrameSizeKHR Dereference(this VkVideoEncodeH264FrameSizeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264FrameSizeKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264FrameSizeKHRExterns
{
}


public struct VkVideoEncodeH264FrameSizeKHR
{
}

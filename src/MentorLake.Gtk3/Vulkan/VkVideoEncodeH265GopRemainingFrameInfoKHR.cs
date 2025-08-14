namespace MentorLake.Vulkan;


public class VkVideoEncodeH265GopRemainingFrameInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265GopRemainingFrameInfoKHRExtensions
{

	public static VkVideoEncodeH265GopRemainingFrameInfoKHR Dereference(this VkVideoEncodeH265GopRemainingFrameInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265GopRemainingFrameInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265GopRemainingFrameInfoKHRExterns
{
}


public struct VkVideoEncodeH265GopRemainingFrameInfoKHR
{
}

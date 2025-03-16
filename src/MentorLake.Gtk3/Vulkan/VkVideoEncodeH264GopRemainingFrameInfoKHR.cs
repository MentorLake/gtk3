namespace MentorLake.Vulkan;

public class VkVideoEncodeH264GopRemainingFrameInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264GopRemainingFrameInfoKHRExtensions
{

	public static VkVideoEncodeH264GopRemainingFrameInfoKHR Dereference(this VkVideoEncodeH264GopRemainingFrameInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264GopRemainingFrameInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264GopRemainingFrameInfoKHRExterns
{
}

public struct VkVideoEncodeH264GopRemainingFrameInfoKHR
{
}

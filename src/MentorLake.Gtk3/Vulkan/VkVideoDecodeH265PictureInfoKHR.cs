namespace MentorLake.Vulkan;

public class VkVideoDecodeH265PictureInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH265PictureInfoKHRExtensions
{

	public static VkVideoDecodeH265PictureInfoKHR Dereference(this VkVideoDecodeH265PictureInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH265PictureInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH265PictureInfoKHRExterns
{
}

public struct VkVideoDecodeH265PictureInfoKHR
{
}

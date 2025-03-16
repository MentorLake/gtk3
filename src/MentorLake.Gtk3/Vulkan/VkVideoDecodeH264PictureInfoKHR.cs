namespace MentorLake.Vulkan;

public class VkVideoDecodeH264PictureInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH264PictureInfoKHRExtensions
{

	public static VkVideoDecodeH264PictureInfoKHR Dereference(this VkVideoDecodeH264PictureInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH264PictureInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH264PictureInfoKHRExterns
{
}

public struct VkVideoDecodeH264PictureInfoKHR
{
}

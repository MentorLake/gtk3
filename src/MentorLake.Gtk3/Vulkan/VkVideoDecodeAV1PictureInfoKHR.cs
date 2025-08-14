namespace MentorLake.Vulkan;


public class VkVideoDecodeAV1PictureInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeAV1PictureInfoKHRExtensions
{

	public static VkVideoDecodeAV1PictureInfoKHR Dereference(this VkVideoDecodeAV1PictureInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeAV1PictureInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeAV1PictureInfoKHRExterns
{
}


public struct VkVideoDecodeAV1PictureInfoKHR
{
}

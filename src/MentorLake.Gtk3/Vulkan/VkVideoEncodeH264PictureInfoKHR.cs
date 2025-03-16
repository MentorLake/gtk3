namespace MentorLake.Vulkan;

public class VkVideoEncodeH264PictureInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264PictureInfoKHRExtensions
{

	public static VkVideoEncodeH264PictureInfoKHR Dereference(this VkVideoEncodeH264PictureInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264PictureInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264PictureInfoKHRExterns
{
}

public struct VkVideoEncodeH264PictureInfoKHR
{
}

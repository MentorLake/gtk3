namespace MentorLake.Vulkan;

public class VkVideoEncodeH265PictureInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265PictureInfoKHRExtensions
{

	public static VkVideoEncodeH265PictureInfoKHR Dereference(this VkVideoEncodeH265PictureInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265PictureInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265PictureInfoKHRExterns
{
}

public struct VkVideoEncodeH265PictureInfoKHR
{
}

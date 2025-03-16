namespace MentorLake.Vulkan;

public class VkVideoDecodeH264PictureLayoutFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH264PictureLayoutFlagsKHRExtensions
{

	public static VkVideoDecodeH264PictureLayoutFlagsKHR Dereference(this VkVideoDecodeH264PictureLayoutFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH264PictureLayoutFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH264PictureLayoutFlagsKHRExterns
{
}

public struct VkVideoDecodeH264PictureLayoutFlagsKHR
{
}

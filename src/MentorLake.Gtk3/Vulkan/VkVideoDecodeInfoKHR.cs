namespace MentorLake.Vulkan;

public class VkVideoDecodeInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeInfoKHRExtensions
{

	public static VkVideoDecodeInfoKHR Dereference(this VkVideoDecodeInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeInfoKHRExterns
{
}

public struct VkVideoDecodeInfoKHR
{
}

namespace MentorLake.Vulkan;

public class VkVideoDecodeH264ProfileInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH264ProfileInfoKHRExtensions
{

	public static VkVideoDecodeH264ProfileInfoKHR Dereference(this VkVideoDecodeH264ProfileInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH264ProfileInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH264ProfileInfoKHRExterns
{
}

public struct VkVideoDecodeH264ProfileInfoKHR
{
}

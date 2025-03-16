namespace MentorLake.Vulkan;

public class VkVideoDecodeH264SessionParametersAddInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH264SessionParametersAddInfoKHRExtensions
{

	public static VkVideoDecodeH264SessionParametersAddInfoKHR Dereference(this VkVideoDecodeH264SessionParametersAddInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH264SessionParametersAddInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH264SessionParametersAddInfoKHRExterns
{
}

public struct VkVideoDecodeH264SessionParametersAddInfoKHR
{
}

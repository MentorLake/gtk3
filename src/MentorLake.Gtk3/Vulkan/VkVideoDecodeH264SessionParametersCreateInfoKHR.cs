namespace MentorLake.Vulkan;

public class VkVideoDecodeH264SessionParametersCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH264SessionParametersCreateInfoKHRExtensions
{

	public static VkVideoDecodeH264SessionParametersCreateInfoKHR Dereference(this VkVideoDecodeH264SessionParametersCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH264SessionParametersCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH264SessionParametersCreateInfoKHRExterns
{
}

public struct VkVideoDecodeH264SessionParametersCreateInfoKHR
{
}

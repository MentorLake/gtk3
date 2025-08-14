namespace MentorLake.Vulkan;


public class VkVideoDecodeAV1SessionParametersCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeAV1SessionParametersCreateInfoKHRExtensions
{

	public static VkVideoDecodeAV1SessionParametersCreateInfoKHR Dereference(this VkVideoDecodeAV1SessionParametersCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeAV1SessionParametersCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeAV1SessionParametersCreateInfoKHRExterns
{
}


public struct VkVideoDecodeAV1SessionParametersCreateInfoKHR
{
}

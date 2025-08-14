namespace MentorLake.Vulkan;


public class VkVideoDecodeH265SessionParametersCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH265SessionParametersCreateInfoKHRExtensions
{

	public static VkVideoDecodeH265SessionParametersCreateInfoKHR Dereference(this VkVideoDecodeH265SessionParametersCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH265SessionParametersCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH265SessionParametersCreateInfoKHRExterns
{
}


public struct VkVideoDecodeH265SessionParametersCreateInfoKHR
{
}

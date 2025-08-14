namespace MentorLake.Vulkan;


public class VkVideoDecodeH265SessionParametersAddInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH265SessionParametersAddInfoKHRExtensions
{

	public static VkVideoDecodeH265SessionParametersAddInfoKHR Dereference(this VkVideoDecodeH265SessionParametersAddInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH265SessionParametersAddInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH265SessionParametersAddInfoKHRExterns
{
}


public struct VkVideoDecodeH265SessionParametersAddInfoKHR
{
}

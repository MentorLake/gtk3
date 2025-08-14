namespace MentorLake.Vulkan;


public class VkVideoEncodeH265SessionParametersAddInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265SessionParametersAddInfoKHRExtensions
{

	public static VkVideoEncodeH265SessionParametersAddInfoKHR Dereference(this VkVideoEncodeH265SessionParametersAddInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265SessionParametersAddInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265SessionParametersAddInfoKHRExterns
{
}


public struct VkVideoEncodeH265SessionParametersAddInfoKHR
{
}

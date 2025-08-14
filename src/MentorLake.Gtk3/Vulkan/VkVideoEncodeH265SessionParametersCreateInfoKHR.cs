namespace MentorLake.Vulkan;


public class VkVideoEncodeH265SessionParametersCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265SessionParametersCreateInfoKHRExtensions
{

	public static VkVideoEncodeH265SessionParametersCreateInfoKHR Dereference(this VkVideoEncodeH265SessionParametersCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265SessionParametersCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265SessionParametersCreateInfoKHRExterns
{
}


public struct VkVideoEncodeH265SessionParametersCreateInfoKHR
{
}

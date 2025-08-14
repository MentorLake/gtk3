namespace MentorLake.Vulkan;


public class VkVideoEncodeH264SessionParametersCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264SessionParametersCreateInfoKHRExtensions
{

	public static VkVideoEncodeH264SessionParametersCreateInfoKHR Dereference(this VkVideoEncodeH264SessionParametersCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264SessionParametersCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264SessionParametersCreateInfoKHRExterns
{
}


public struct VkVideoEncodeH264SessionParametersCreateInfoKHR
{
}

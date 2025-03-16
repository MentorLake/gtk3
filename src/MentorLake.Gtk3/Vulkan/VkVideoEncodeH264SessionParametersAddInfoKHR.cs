namespace MentorLake.Vulkan;

public class VkVideoEncodeH264SessionParametersAddInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264SessionParametersAddInfoKHRExtensions
{

	public static VkVideoEncodeH264SessionParametersAddInfoKHR Dereference(this VkVideoEncodeH264SessionParametersAddInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264SessionParametersAddInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264SessionParametersAddInfoKHRExterns
{
}

public struct VkVideoEncodeH264SessionParametersAddInfoKHR
{
}

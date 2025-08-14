namespace MentorLake.Vulkan;


public class VkVideoEncodeH264SessionParametersGetInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264SessionParametersGetInfoKHRExtensions
{

	public static VkVideoEncodeH264SessionParametersGetInfoKHR Dereference(this VkVideoEncodeH264SessionParametersGetInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264SessionParametersGetInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264SessionParametersGetInfoKHRExterns
{
}


public struct VkVideoEncodeH264SessionParametersGetInfoKHR
{
}

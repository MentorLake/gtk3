namespace MentorLake.Vulkan;


public class VkVideoEncodeH265SessionParametersGetInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265SessionParametersGetInfoKHRExtensions
{

	public static VkVideoEncodeH265SessionParametersGetInfoKHR Dereference(this VkVideoEncodeH265SessionParametersGetInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265SessionParametersGetInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265SessionParametersGetInfoKHRExterns
{
}


public struct VkVideoEncodeH265SessionParametersGetInfoKHR
{
}

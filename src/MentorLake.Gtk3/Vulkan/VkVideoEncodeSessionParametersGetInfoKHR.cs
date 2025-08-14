namespace MentorLake.Vulkan;


public class VkVideoEncodeSessionParametersGetInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeSessionParametersGetInfoKHRExtensions
{

	public static VkVideoEncodeSessionParametersGetInfoKHR Dereference(this VkVideoEncodeSessionParametersGetInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeSessionParametersGetInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeSessionParametersGetInfoKHRExterns
{
}


public struct VkVideoEncodeSessionParametersGetInfoKHR
{
}

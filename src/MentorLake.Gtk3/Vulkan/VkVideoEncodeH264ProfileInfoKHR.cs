namespace MentorLake.Vulkan;


public class VkVideoEncodeH264ProfileInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264ProfileInfoKHRExtensions
{

	public static VkVideoEncodeH264ProfileInfoKHR Dereference(this VkVideoEncodeH264ProfileInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264ProfileInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264ProfileInfoKHRExterns
{
}


public struct VkVideoEncodeH264ProfileInfoKHR
{
}

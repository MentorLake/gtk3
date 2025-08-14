namespace MentorLake.Vulkan;


public class VkVideoDecodeH265ProfileInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH265ProfileInfoKHRExtensions
{

	public static VkVideoDecodeH265ProfileInfoKHR Dereference(this VkVideoDecodeH265ProfileInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH265ProfileInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH265ProfileInfoKHRExterns
{
}


public struct VkVideoDecodeH265ProfileInfoKHR
{
}

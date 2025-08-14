namespace MentorLake.Vulkan;


public class VkVideoEncodeH265ProfileInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265ProfileInfoKHRExtensions
{

	public static VkVideoEncodeH265ProfileInfoKHR Dereference(this VkVideoEncodeH265ProfileInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265ProfileInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265ProfileInfoKHRExterns
{
}


public struct VkVideoEncodeH265ProfileInfoKHR
{
}

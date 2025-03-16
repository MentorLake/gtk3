namespace MentorLake.Vulkan;

public class VkVideoEncodeH265SessionCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265SessionCreateInfoKHRExtensions
{

	public static VkVideoEncodeH265SessionCreateInfoKHR Dereference(this VkVideoEncodeH265SessionCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265SessionCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265SessionCreateInfoKHRExterns
{
}

public struct VkVideoEncodeH265SessionCreateInfoKHR
{
}

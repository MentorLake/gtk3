namespace MentorLake.Vulkan;

public class VkVideoEncodeH264SessionCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264SessionCreateInfoKHRExtensions
{

	public static VkVideoEncodeH264SessionCreateInfoKHR Dereference(this VkVideoEncodeH264SessionCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264SessionCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264SessionCreateInfoKHRExterns
{
}

public struct VkVideoEncodeH264SessionCreateInfoKHR
{
}

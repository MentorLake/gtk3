namespace MentorLake.Vulkan;


public class VkVideoEncodeFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeFlagBitsKHRExtensions
{

	public static VkVideoEncodeFlagBitsKHR Dereference(this VkVideoEncodeFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeFlagBitsKHRExterns
{
}


public struct VkVideoEncodeFlagBitsKHR
{
}

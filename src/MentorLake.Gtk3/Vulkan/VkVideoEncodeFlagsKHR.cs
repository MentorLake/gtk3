namespace MentorLake.Vulkan;


public class VkVideoEncodeFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeFlagsKHRExtensions
{

	public static VkVideoEncodeFlagsKHR Dereference(this VkVideoEncodeFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeFlagsKHRExterns
{
}


public struct VkVideoEncodeFlagsKHR
{
}

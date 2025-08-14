namespace MentorLake.Vulkan;


public class VkVideoDecodeFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeFlagsKHRExtensions
{

	public static VkVideoDecodeFlagsKHR Dereference(this VkVideoDecodeFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeFlagsKHRExterns
{
}


public struct VkVideoDecodeFlagsKHR
{
}

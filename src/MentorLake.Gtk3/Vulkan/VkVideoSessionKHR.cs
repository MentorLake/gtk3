namespace MentorLake.Vulkan;


public class VkVideoSessionKHRHandle : BaseSafeHandle
{
}


public static class VkVideoSessionKHRExtensions
{

	public static VkVideoSessionKHR Dereference(this VkVideoSessionKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoSessionKHR>(x.DangerousGetHandle());
}
internal class VkVideoSessionKHRExterns
{
}


public struct VkVideoSessionKHR
{
}

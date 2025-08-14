namespace MentorLake.Vulkan;


public class VkPresentIdKHRHandle : BaseSafeHandle
{
}


public static class VkPresentIdKHRExtensions
{

	public static VkPresentIdKHR Dereference(this VkPresentIdKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentIdKHR>(x.DangerousGetHandle());
}
internal class VkPresentIdKHRExterns
{
}


public struct VkPresentIdKHR
{
}

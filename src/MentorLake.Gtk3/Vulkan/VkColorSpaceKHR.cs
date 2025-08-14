namespace MentorLake.Vulkan;


public class VkColorSpaceKHRHandle : BaseSafeHandle
{
}


public static class VkColorSpaceKHRExtensions
{

	public static VkColorSpaceKHR Dereference(this VkColorSpaceKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkColorSpaceKHR>(x.DangerousGetHandle());
}
internal class VkColorSpaceKHRExterns
{
}


public struct VkColorSpaceKHR
{
}

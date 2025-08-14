namespace MentorLake.Vulkan;


public class VkImageFormatListCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkImageFormatListCreateInfoKHRExtensions
{

	public static VkImageFormatListCreateInfoKHR Dereference(this VkImageFormatListCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageFormatListCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkImageFormatListCreateInfoKHRExterns
{
}


public struct VkImageFormatListCreateInfoKHR
{
}

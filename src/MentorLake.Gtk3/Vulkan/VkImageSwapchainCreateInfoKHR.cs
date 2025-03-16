namespace MentorLake.Vulkan;

public class VkImageSwapchainCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkImageSwapchainCreateInfoKHRExtensions
{

	public static VkImageSwapchainCreateInfoKHR Dereference(this VkImageSwapchainCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageSwapchainCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkImageSwapchainCreateInfoKHRExterns
{
}

public struct VkImageSwapchainCreateInfoKHR
{
}

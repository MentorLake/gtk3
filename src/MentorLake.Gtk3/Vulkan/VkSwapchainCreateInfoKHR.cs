namespace MentorLake.Vulkan;

public class VkSwapchainCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSwapchainCreateInfoKHRExtensions
{

	public static VkSwapchainCreateInfoKHR Dereference(this VkSwapchainCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkSwapchainCreateInfoKHRExterns
{
}

public struct VkSwapchainCreateInfoKHR
{
}

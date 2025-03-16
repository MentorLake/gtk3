namespace MentorLake.Vulkan;

public class VkDeviceGroupSwapchainCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupSwapchainCreateInfoKHRExtensions
{

	public static VkDeviceGroupSwapchainCreateInfoKHR Dereference(this VkDeviceGroupSwapchainCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupSwapchainCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupSwapchainCreateInfoKHRExterns
{
}

public struct VkDeviceGroupSwapchainCreateInfoKHR
{
}

namespace MentorLake.Vulkan;


public class VkBindImageMemorySwapchainInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBindImageMemorySwapchainInfoKHRExtensions
{

	public static VkBindImageMemorySwapchainInfoKHR Dereference(this VkBindImageMemorySwapchainInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindImageMemorySwapchainInfoKHR>(x.DangerousGetHandle());
}
internal class VkBindImageMemorySwapchainInfoKHRExterns
{
}


public struct VkBindImageMemorySwapchainInfoKHR
{
}

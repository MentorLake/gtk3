namespace MentorLake.Vulkan;

public class VkSwapchainKHRHandle : BaseSafeHandle
{
}


public static class VkSwapchainKHRExtensions
{

	public static VkSwapchainKHR Dereference(this VkSwapchainKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainKHR>(x.DangerousGetHandle());
}
internal class VkSwapchainKHRExterns
{
}

public struct VkSwapchainKHR
{
}

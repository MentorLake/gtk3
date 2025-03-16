namespace MentorLake.Vulkan;

public class VkSwapchainLatencyCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkSwapchainLatencyCreateInfoNVExtensions
{

	public static VkSwapchainLatencyCreateInfoNV Dereference(this VkSwapchainLatencyCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainLatencyCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkSwapchainLatencyCreateInfoNVExterns
{
}

public struct VkSwapchainLatencyCreateInfoNV
{
}

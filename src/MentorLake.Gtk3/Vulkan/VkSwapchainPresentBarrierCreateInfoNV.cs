namespace MentorLake.Vulkan;


public class VkSwapchainPresentBarrierCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkSwapchainPresentBarrierCreateInfoNVExtensions
{

	public static VkSwapchainPresentBarrierCreateInfoNV Dereference(this VkSwapchainPresentBarrierCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainPresentBarrierCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkSwapchainPresentBarrierCreateInfoNVExterns
{
}


public struct VkSwapchainPresentBarrierCreateInfoNV
{
}

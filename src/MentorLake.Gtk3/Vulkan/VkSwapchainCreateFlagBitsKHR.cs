namespace MentorLake.Vulkan;

public class VkSwapchainCreateFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkSwapchainCreateFlagBitsKHRExtensions
{

	public static VkSwapchainCreateFlagBitsKHR Dereference(this VkSwapchainCreateFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainCreateFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkSwapchainCreateFlagBitsKHRExterns
{
}

public struct VkSwapchainCreateFlagBitsKHR
{
}

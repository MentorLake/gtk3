namespace MentorLake.Vulkan;

public class VkSwapchainCreateFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkSwapchainCreateFlagsKHRExtensions
{

	public static VkSwapchainCreateFlagsKHR Dereference(this VkSwapchainCreateFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainCreateFlagsKHR>(x.DangerousGetHandle());
}
internal class VkSwapchainCreateFlagsKHRExterns
{
}

public struct VkSwapchainCreateFlagsKHR
{
}

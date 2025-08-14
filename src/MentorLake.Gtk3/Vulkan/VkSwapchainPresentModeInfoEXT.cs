namespace MentorLake.Vulkan;


public class VkSwapchainPresentModeInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSwapchainPresentModeInfoEXTExtensions
{

	public static VkSwapchainPresentModeInfoEXT Dereference(this VkSwapchainPresentModeInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainPresentModeInfoEXT>(x.DangerousGetHandle());
}
internal class VkSwapchainPresentModeInfoEXTExterns
{
}


public struct VkSwapchainPresentModeInfoEXT
{
}

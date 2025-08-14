namespace MentorLake.Vulkan;


public class VkSwapchainPresentModesCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSwapchainPresentModesCreateInfoEXTExtensions
{

	public static VkSwapchainPresentModesCreateInfoEXT Dereference(this VkSwapchainPresentModesCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainPresentModesCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkSwapchainPresentModesCreateInfoEXTExterns
{
}


public struct VkSwapchainPresentModesCreateInfoEXT
{
}

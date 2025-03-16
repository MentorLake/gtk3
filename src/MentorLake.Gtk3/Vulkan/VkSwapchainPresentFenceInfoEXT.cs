namespace MentorLake.Vulkan;

public class VkSwapchainPresentFenceInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSwapchainPresentFenceInfoEXTExtensions
{

	public static VkSwapchainPresentFenceInfoEXT Dereference(this VkSwapchainPresentFenceInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainPresentFenceInfoEXT>(x.DangerousGetHandle());
}
internal class VkSwapchainPresentFenceInfoEXTExterns
{
}

public struct VkSwapchainPresentFenceInfoEXT
{
}

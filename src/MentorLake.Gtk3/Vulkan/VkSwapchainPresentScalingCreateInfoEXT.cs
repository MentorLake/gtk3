namespace MentorLake.Vulkan;

public class VkSwapchainPresentScalingCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSwapchainPresentScalingCreateInfoEXTExtensions
{

	public static VkSwapchainPresentScalingCreateInfoEXT Dereference(this VkSwapchainPresentScalingCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainPresentScalingCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkSwapchainPresentScalingCreateInfoEXTExterns
{
}

public struct VkSwapchainPresentScalingCreateInfoEXT
{
}

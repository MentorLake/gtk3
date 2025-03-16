namespace MentorLake.Vulkan;

public class VkPhysicalDeviceImagelessFramebufferFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImagelessFramebufferFeaturesKHRExtensions
{

	public static VkPhysicalDeviceImagelessFramebufferFeaturesKHR Dereference(this VkPhysicalDeviceImagelessFramebufferFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImagelessFramebufferFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImagelessFramebufferFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceImagelessFramebufferFeaturesKHR
{
}

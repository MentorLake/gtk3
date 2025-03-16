namespace MentorLake.Vulkan;

public class VkPhysicalDeviceImagelessFramebufferFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImagelessFramebufferFeaturesExtensions
{

	public static VkPhysicalDeviceImagelessFramebufferFeatures Dereference(this VkPhysicalDeviceImagelessFramebufferFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImagelessFramebufferFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImagelessFramebufferFeaturesExterns
{
}

public struct VkPhysicalDeviceImagelessFramebufferFeatures
{
}

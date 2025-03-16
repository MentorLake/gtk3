namespace MentorLake.Vulkan;

public class VkPhysicalDeviceVulkanMemoryModelFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVulkanMemoryModelFeaturesExtensions
{

	public static VkPhysicalDeviceVulkanMemoryModelFeatures Dereference(this VkPhysicalDeviceVulkanMemoryModelFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVulkanMemoryModelFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVulkanMemoryModelFeaturesExterns
{
}

public struct VkPhysicalDeviceVulkanMemoryModelFeatures
{
}

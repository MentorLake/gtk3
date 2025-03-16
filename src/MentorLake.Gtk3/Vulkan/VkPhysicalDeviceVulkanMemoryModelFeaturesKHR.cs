namespace MentorLake.Vulkan;

public class VkPhysicalDeviceVulkanMemoryModelFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVulkanMemoryModelFeaturesKHRExtensions
{

	public static VkPhysicalDeviceVulkanMemoryModelFeaturesKHR Dereference(this VkPhysicalDeviceVulkanMemoryModelFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVulkanMemoryModelFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVulkanMemoryModelFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR
{
}

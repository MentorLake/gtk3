namespace MentorLake.Vulkan;

public class VkPhysicalDeviceVulkan12FeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVulkan12FeaturesExtensions
{

	public static VkPhysicalDeviceVulkan12Features Dereference(this VkPhysicalDeviceVulkan12FeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVulkan12Features>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVulkan12FeaturesExterns
{
}

public struct VkPhysicalDeviceVulkan12Features
{
}

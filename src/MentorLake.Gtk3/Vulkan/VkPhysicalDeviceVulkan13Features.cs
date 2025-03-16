namespace MentorLake.Vulkan;

public class VkPhysicalDeviceVulkan13FeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVulkan13FeaturesExtensions
{

	public static VkPhysicalDeviceVulkan13Features Dereference(this VkPhysicalDeviceVulkan13FeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVulkan13Features>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVulkan13FeaturesExterns
{
}

public struct VkPhysicalDeviceVulkan13Features
{
}

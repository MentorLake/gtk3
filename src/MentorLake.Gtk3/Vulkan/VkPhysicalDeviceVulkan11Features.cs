namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVulkan11FeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVulkan11FeaturesExtensions
{

	public static VkPhysicalDeviceVulkan11Features Dereference(this VkPhysicalDeviceVulkan11FeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVulkan11Features>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVulkan11FeaturesExterns
{
}


public struct VkPhysicalDeviceVulkan11Features
{
}

namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVulkan13PropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVulkan13PropertiesExtensions
{

	public static VkPhysicalDeviceVulkan13Properties Dereference(this VkPhysicalDeviceVulkan13PropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVulkan13Properties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVulkan13PropertiesExterns
{
}


public struct VkPhysicalDeviceVulkan13Properties
{
}

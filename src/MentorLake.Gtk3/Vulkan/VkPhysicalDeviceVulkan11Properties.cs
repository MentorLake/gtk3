namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVulkan11PropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVulkan11PropertiesExtensions
{

	public static VkPhysicalDeviceVulkan11Properties Dereference(this VkPhysicalDeviceVulkan11PropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVulkan11Properties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVulkan11PropertiesExterns
{
}


public struct VkPhysicalDeviceVulkan11Properties
{
}

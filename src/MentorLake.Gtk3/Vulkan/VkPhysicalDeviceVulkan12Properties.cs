namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVulkan12PropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVulkan12PropertiesExtensions
{

	public static VkPhysicalDeviceVulkan12Properties Dereference(this VkPhysicalDeviceVulkan12PropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVulkan12Properties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVulkan12PropertiesExterns
{
}


public struct VkPhysicalDeviceVulkan12Properties
{
}

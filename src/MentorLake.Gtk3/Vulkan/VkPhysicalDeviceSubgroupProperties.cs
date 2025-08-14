namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSubgroupPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSubgroupPropertiesExtensions
{

	public static VkPhysicalDeviceSubgroupProperties Dereference(this VkPhysicalDeviceSubgroupPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSubgroupProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSubgroupPropertiesExterns
{
}


public struct VkPhysicalDeviceSubgroupProperties
{
}

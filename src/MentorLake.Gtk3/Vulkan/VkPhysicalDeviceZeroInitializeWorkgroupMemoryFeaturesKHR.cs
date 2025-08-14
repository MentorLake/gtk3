namespace MentorLake.Vulkan;


public class VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHRExtensions
{

	public static VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR Dereference(this VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHRExterns
{
}


public struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR
{
}

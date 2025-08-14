namespace MentorLake.Vulkan;


public class VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesExtensions
{

	public static VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures Dereference(this VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesExterns
{
}


public struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
{
}

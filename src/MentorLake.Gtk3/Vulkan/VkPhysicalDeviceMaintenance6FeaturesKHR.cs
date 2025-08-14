namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMaintenance6FeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance6FeaturesKHRExtensions
{

	public static VkPhysicalDeviceMaintenance6FeaturesKHR Dereference(this VkPhysicalDeviceMaintenance6FeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance6FeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance6FeaturesKHRExterns
{
}


public struct VkPhysicalDeviceMaintenance6FeaturesKHR
{
}

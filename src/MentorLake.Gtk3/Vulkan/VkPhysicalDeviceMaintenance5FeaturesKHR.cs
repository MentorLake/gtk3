namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMaintenance5FeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance5FeaturesKHRExtensions
{

	public static VkPhysicalDeviceMaintenance5FeaturesKHR Dereference(this VkPhysicalDeviceMaintenance5FeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance5FeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance5FeaturesKHRExterns
{
}


public struct VkPhysicalDeviceMaintenance5FeaturesKHR
{
}

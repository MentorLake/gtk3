namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMaintenance4FeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance4FeaturesKHRExtensions
{

	public static VkPhysicalDeviceMaintenance4FeaturesKHR Dereference(this VkPhysicalDeviceMaintenance4FeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance4FeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance4FeaturesKHRExterns
{
}


public struct VkPhysicalDeviceMaintenance4FeaturesKHR
{
}

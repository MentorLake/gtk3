namespace MentorLake.Vulkan;


public class VkPhysicalDeviceIndexTypeUint8FeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceIndexTypeUint8FeaturesKHRExtensions
{

	public static VkPhysicalDeviceIndexTypeUint8FeaturesKHR Dereference(this VkPhysicalDeviceIndexTypeUint8FeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceIndexTypeUint8FeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceIndexTypeUint8FeaturesKHRExterns
{
}


public struct VkPhysicalDeviceIndexTypeUint8FeaturesKHR
{
}

namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMultiviewFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMultiviewFeaturesKHRExtensions
{

	public static VkPhysicalDeviceMultiviewFeaturesKHR Dereference(this VkPhysicalDeviceMultiviewFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMultiviewFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMultiviewFeaturesKHRExterns
{
}


public struct VkPhysicalDeviceMultiviewFeaturesKHR
{
}

namespace MentorLake.Vulkan;


public class VkPhysicalDevicePresentWaitFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePresentWaitFeaturesKHRExtensions
{

	public static VkPhysicalDevicePresentWaitFeaturesKHR Dereference(this VkPhysicalDevicePresentWaitFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePresentWaitFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePresentWaitFeaturesKHRExterns
{
}


public struct VkPhysicalDevicePresentWaitFeaturesKHR
{
}

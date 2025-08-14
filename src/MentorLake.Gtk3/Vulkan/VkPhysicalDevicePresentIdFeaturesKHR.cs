namespace MentorLake.Vulkan;


public class VkPhysicalDevicePresentIdFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePresentIdFeaturesKHRExtensions
{

	public static VkPhysicalDevicePresentIdFeaturesKHR Dereference(this VkPhysicalDevicePresentIdFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePresentIdFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePresentIdFeaturesKHRExterns
{
}


public struct VkPhysicalDevicePresentIdFeaturesKHR
{
}

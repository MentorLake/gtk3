namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMultiviewFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMultiviewFeaturesExtensions
{

	public static VkPhysicalDeviceMultiviewFeatures Dereference(this VkPhysicalDeviceMultiviewFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMultiviewFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMultiviewFeaturesExterns
{
}


public struct VkPhysicalDeviceMultiviewFeatures
{
}

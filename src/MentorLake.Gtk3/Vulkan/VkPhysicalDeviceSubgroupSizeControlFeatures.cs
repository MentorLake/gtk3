namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSubgroupSizeControlFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSubgroupSizeControlFeaturesExtensions
{

	public static VkPhysicalDeviceSubgroupSizeControlFeatures Dereference(this VkPhysicalDeviceSubgroupSizeControlFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSubgroupSizeControlFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSubgroupSizeControlFeaturesExterns
{
}

public struct VkPhysicalDeviceSubgroupSizeControlFeatures
{
}

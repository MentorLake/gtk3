namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSubgroupSizeControlFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSubgroupSizeControlFeaturesEXTExtensions
{

	public static VkPhysicalDeviceSubgroupSizeControlFeaturesEXT Dereference(this VkPhysicalDeviceSubgroupSizeControlFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSubgroupSizeControlFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSubgroupSizeControlFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
{
}

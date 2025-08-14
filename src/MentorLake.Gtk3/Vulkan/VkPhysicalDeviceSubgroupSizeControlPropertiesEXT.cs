namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSubgroupSizeControlPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSubgroupSizeControlPropertiesEXTExtensions
{

	public static VkPhysicalDeviceSubgroupSizeControlPropertiesEXT Dereference(this VkPhysicalDeviceSubgroupSizeControlPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSubgroupSizeControlPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSubgroupSizeControlPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
{
}

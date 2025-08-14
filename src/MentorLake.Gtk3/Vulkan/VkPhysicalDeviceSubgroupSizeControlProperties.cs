namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSubgroupSizeControlPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSubgroupSizeControlPropertiesExtensions
{

	public static VkPhysicalDeviceSubgroupSizeControlProperties Dereference(this VkPhysicalDeviceSubgroupSizeControlPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSubgroupSizeControlProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSubgroupSizeControlPropertiesExterns
{
}


public struct VkPhysicalDeviceSubgroupSizeControlProperties
{
}

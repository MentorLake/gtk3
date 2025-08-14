namespace MentorLake.Vulkan;


public class VkPhysicalDeviceGlobalPriorityQueryFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceGlobalPriorityQueryFeaturesEXTExtensions
{

	public static VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT Dereference(this VkPhysicalDeviceGlobalPriorityQueryFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceGlobalPriorityQueryFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT
{
}

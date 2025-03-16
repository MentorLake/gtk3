namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSampleLocationsPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSampleLocationsPropertiesEXTExtensions
{

	public static VkPhysicalDeviceSampleLocationsPropertiesEXT Dereference(this VkPhysicalDeviceSampleLocationsPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSampleLocationsPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSampleLocationsPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceSampleLocationsPropertiesEXT
{
}

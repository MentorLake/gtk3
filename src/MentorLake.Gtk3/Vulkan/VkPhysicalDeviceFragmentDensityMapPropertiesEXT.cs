namespace MentorLake.Vulkan;


public class VkPhysicalDeviceFragmentDensityMapPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFragmentDensityMapPropertiesEXTExtensions
{

	public static VkPhysicalDeviceFragmentDensityMapPropertiesEXT Dereference(this VkPhysicalDeviceFragmentDensityMapPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFragmentDensityMapPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFragmentDensityMapPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
{
}

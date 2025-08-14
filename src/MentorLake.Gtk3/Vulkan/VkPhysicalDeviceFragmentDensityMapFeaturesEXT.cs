namespace MentorLake.Vulkan;


public class VkPhysicalDeviceFragmentDensityMapFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFragmentDensityMapFeaturesEXTExtensions
{

	public static VkPhysicalDeviceFragmentDensityMapFeaturesEXT Dereference(this VkPhysicalDeviceFragmentDensityMapFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFragmentDensityMapFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFragmentDensityMapFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
{
}

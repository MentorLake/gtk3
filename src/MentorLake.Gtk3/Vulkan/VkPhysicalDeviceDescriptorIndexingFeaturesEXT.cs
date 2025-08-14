namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDescriptorIndexingFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDescriptorIndexingFeaturesEXTExtensions
{

	public static VkPhysicalDeviceDescriptorIndexingFeaturesEXT Dereference(this VkPhysicalDeviceDescriptorIndexingFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDescriptorIndexingFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDescriptorIndexingFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
{
}

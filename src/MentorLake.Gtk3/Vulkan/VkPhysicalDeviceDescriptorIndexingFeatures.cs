namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDescriptorIndexingFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDescriptorIndexingFeaturesExtensions
{

	public static VkPhysicalDeviceDescriptorIndexingFeatures Dereference(this VkPhysicalDeviceDescriptorIndexingFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDescriptorIndexingFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDescriptorIndexingFeaturesExterns
{
}


public struct VkPhysicalDeviceDescriptorIndexingFeatures
{
}

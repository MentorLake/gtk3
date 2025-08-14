namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDescriptorBufferFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDescriptorBufferFeaturesEXTExtensions
{

	public static VkPhysicalDeviceDescriptorBufferFeaturesEXT Dereference(this VkPhysicalDeviceDescriptorBufferFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDescriptorBufferFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDescriptorBufferFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
{
}

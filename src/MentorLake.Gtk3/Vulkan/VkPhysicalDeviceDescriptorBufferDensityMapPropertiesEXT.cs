namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXTExtensions
{

	public static VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT Dereference(this VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT
{
}

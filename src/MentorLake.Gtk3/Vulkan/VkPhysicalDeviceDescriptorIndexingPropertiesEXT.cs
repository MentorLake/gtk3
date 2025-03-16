namespace MentorLake.Vulkan;

public class VkPhysicalDeviceDescriptorIndexingPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDescriptorIndexingPropertiesEXTExtensions
{

	public static VkPhysicalDeviceDescriptorIndexingPropertiesEXT Dereference(this VkPhysicalDeviceDescriptorIndexingPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDescriptorIndexingPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDescriptorIndexingPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT
{
}

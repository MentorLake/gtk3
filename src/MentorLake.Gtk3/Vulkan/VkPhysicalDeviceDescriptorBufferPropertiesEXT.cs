namespace MentorLake.Vulkan;

public class VkPhysicalDeviceDescriptorBufferPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDescriptorBufferPropertiesEXTExtensions
{

	public static VkPhysicalDeviceDescriptorBufferPropertiesEXT Dereference(this VkPhysicalDeviceDescriptorBufferPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDescriptorBufferPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDescriptorBufferPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
{
}

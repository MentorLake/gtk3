namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDescriptorIndexingPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDescriptorIndexingPropertiesExtensions
{

	public static VkPhysicalDeviceDescriptorIndexingProperties Dereference(this VkPhysicalDeviceDescriptorIndexingPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDescriptorIndexingProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDescriptorIndexingPropertiesExterns
{
}


public struct VkPhysicalDeviceDescriptorIndexingProperties
{
}

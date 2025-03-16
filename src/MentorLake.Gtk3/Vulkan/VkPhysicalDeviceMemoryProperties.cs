namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMemoryPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMemoryPropertiesExtensions
{

	public static VkPhysicalDeviceMemoryProperties Dereference(this VkPhysicalDeviceMemoryPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMemoryProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMemoryPropertiesExterns
{
}

public struct VkPhysicalDeviceMemoryProperties
{
}

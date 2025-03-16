namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMemoryDecompressionPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMemoryDecompressionPropertiesNVExtensions
{

	public static VkPhysicalDeviceMemoryDecompressionPropertiesNV Dereference(this VkPhysicalDeviceMemoryDecompressionPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMemoryDecompressionPropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMemoryDecompressionPropertiesNVExterns
{
}

public struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
{
}

namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMemoryDecompressionFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMemoryDecompressionFeaturesNVExtensions
{

	public static VkPhysicalDeviceMemoryDecompressionFeaturesNV Dereference(this VkPhysicalDeviceMemoryDecompressionFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMemoryDecompressionFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMemoryDecompressionFeaturesNVExterns
{
}


public struct VkPhysicalDeviceMemoryDecompressionFeaturesNV
{
}

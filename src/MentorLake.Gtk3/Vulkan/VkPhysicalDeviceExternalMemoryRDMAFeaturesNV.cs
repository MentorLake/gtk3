namespace MentorLake.Vulkan;

public class VkPhysicalDeviceExternalMemoryRDMAFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalMemoryRDMAFeaturesNVExtensions
{

	public static VkPhysicalDeviceExternalMemoryRDMAFeaturesNV Dereference(this VkPhysicalDeviceExternalMemoryRDMAFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalMemoryRDMAFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalMemoryRDMAFeaturesNVExterns
{
}

public struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
{
}

namespace MentorLake.Vulkan;

public class VkPhysicalDeviceCornerSampledImageFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCornerSampledImageFeaturesNVExtensions
{

	public static VkPhysicalDeviceCornerSampledImageFeaturesNV Dereference(this VkPhysicalDeviceCornerSampledImageFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCornerSampledImageFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCornerSampledImageFeaturesNVExterns
{
}

public struct VkPhysicalDeviceCornerSampledImageFeaturesNV
{
}

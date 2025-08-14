namespace MentorLake.Vulkan;


public class VkPhysicalDeviceShadingRateImageFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShadingRateImageFeaturesNVExtensions
{

	public static VkPhysicalDeviceShadingRateImageFeaturesNV Dereference(this VkPhysicalDeviceShadingRateImageFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShadingRateImageFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShadingRateImageFeaturesNVExterns
{
}


public struct VkPhysicalDeviceShadingRateImageFeaturesNV
{
}

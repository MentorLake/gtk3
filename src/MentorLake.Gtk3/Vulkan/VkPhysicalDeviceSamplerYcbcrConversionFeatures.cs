namespace MentorLake.Vulkan;


public class VkPhysicalDeviceSamplerYcbcrConversionFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSamplerYcbcrConversionFeaturesExtensions
{

	public static VkPhysicalDeviceSamplerYcbcrConversionFeatures Dereference(this VkPhysicalDeviceSamplerYcbcrConversionFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSamplerYcbcrConversionFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSamplerYcbcrConversionFeaturesExterns
{
}


public struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
{
}

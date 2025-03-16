namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHRExtensions
{

	public static VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR Dereference(this VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
{
}

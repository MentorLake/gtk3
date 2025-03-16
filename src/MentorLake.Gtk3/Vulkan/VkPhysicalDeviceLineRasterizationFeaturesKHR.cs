namespace MentorLake.Vulkan;

public class VkPhysicalDeviceLineRasterizationFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLineRasterizationFeaturesKHRExtensions
{

	public static VkPhysicalDeviceLineRasterizationFeaturesKHR Dereference(this VkPhysicalDeviceLineRasterizationFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLineRasterizationFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLineRasterizationFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceLineRasterizationFeaturesKHR
{
}

namespace MentorLake.Vulkan;

public class VkPhysicalDeviceFragmentShadingRateFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFragmentShadingRateFeaturesKHRExtensions
{

	public static VkPhysicalDeviceFragmentShadingRateFeaturesKHR Dereference(this VkPhysicalDeviceFragmentShadingRateFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFragmentShadingRateFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFragmentShadingRateFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
{
}

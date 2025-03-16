namespace MentorLake.Vulkan;

public class VkPhysicalDeviceFragmentShadingRatePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFragmentShadingRatePropertiesKHRExtensions
{

	public static VkPhysicalDeviceFragmentShadingRatePropertiesKHR Dereference(this VkPhysicalDeviceFragmentShadingRatePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFragmentShadingRatePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFragmentShadingRatePropertiesKHRExterns
{
}

public struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
}

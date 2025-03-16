namespace MentorLake.Vulkan;

public class VkPhysicalDeviceFragmentShadingRateKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFragmentShadingRateKHRExtensions
{

	public static VkPhysicalDeviceFragmentShadingRateKHR Dereference(this VkPhysicalDeviceFragmentShadingRateKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFragmentShadingRateKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFragmentShadingRateKHRExterns
{
}

public struct VkPhysicalDeviceFragmentShadingRateKHR
{
}

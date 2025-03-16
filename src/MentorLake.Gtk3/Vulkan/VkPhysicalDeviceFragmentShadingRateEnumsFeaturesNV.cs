namespace MentorLake.Vulkan;

public class VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNVExtensions
{

	public static VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV Dereference(this VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNVExterns
{
}

public struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
}

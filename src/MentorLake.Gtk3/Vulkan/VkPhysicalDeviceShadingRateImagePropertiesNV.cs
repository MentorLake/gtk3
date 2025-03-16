namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShadingRateImagePropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShadingRateImagePropertiesNVExtensions
{

	public static VkPhysicalDeviceShadingRateImagePropertiesNV Dereference(this VkPhysicalDeviceShadingRateImagePropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShadingRateImagePropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShadingRateImagePropertiesNVExterns
{
}

public struct VkPhysicalDeviceShadingRateImagePropertiesNV
{
}

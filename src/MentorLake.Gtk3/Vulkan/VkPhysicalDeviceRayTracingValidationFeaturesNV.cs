namespace MentorLake.Vulkan;

public class VkPhysicalDeviceRayTracingValidationFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRayTracingValidationFeaturesNVExtensions
{

	public static VkPhysicalDeviceRayTracingValidationFeaturesNV Dereference(this VkPhysicalDeviceRayTracingValidationFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRayTracingValidationFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRayTracingValidationFeaturesNVExterns
{
}

public struct VkPhysicalDeviceRayTracingValidationFeaturesNV
{
}

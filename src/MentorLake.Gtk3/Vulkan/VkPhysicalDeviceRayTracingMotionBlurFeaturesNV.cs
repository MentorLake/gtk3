namespace MentorLake.Vulkan;

public class VkPhysicalDeviceRayTracingMotionBlurFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRayTracingMotionBlurFeaturesNVExtensions
{

	public static VkPhysicalDeviceRayTracingMotionBlurFeaturesNV Dereference(this VkPhysicalDeviceRayTracingMotionBlurFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRayTracingMotionBlurFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRayTracingMotionBlurFeaturesNVExterns
{
}

public struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
{
}

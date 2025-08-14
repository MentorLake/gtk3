namespace MentorLake.Vulkan;


public class VkPhysicalDeviceRayTracingPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRayTracingPropertiesNVExtensions
{

	public static VkPhysicalDeviceRayTracingPropertiesNV Dereference(this VkPhysicalDeviceRayTracingPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRayTracingPropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRayTracingPropertiesNVExterns
{
}


public struct VkPhysicalDeviceRayTracingPropertiesNV
{
}

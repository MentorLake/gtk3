namespace MentorLake.Vulkan;

public class VkPhysicalDevicePerformanceQueryPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePerformanceQueryPropertiesKHRExtensions
{

	public static VkPhysicalDevicePerformanceQueryPropertiesKHR Dereference(this VkPhysicalDevicePerformanceQueryPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePerformanceQueryPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePerformanceQueryPropertiesKHRExterns
{
}

public struct VkPhysicalDevicePerformanceQueryPropertiesKHR
{
}

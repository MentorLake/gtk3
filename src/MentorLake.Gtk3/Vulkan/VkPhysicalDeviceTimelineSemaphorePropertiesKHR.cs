namespace MentorLake.Vulkan;

public class VkPhysicalDeviceTimelineSemaphorePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTimelineSemaphorePropertiesKHRExtensions
{

	public static VkPhysicalDeviceTimelineSemaphorePropertiesKHR Dereference(this VkPhysicalDeviceTimelineSemaphorePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTimelineSemaphorePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTimelineSemaphorePropertiesKHRExterns
{
}

public struct VkPhysicalDeviceTimelineSemaphorePropertiesKHR
{
}

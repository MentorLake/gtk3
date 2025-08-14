namespace MentorLake.Vulkan;


public class VkPhysicalDeviceTimelineSemaphorePropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTimelineSemaphorePropertiesExtensions
{

	public static VkPhysicalDeviceTimelineSemaphoreProperties Dereference(this VkPhysicalDeviceTimelineSemaphorePropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTimelineSemaphoreProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTimelineSemaphorePropertiesExterns
{
}


public struct VkPhysicalDeviceTimelineSemaphoreProperties
{
}

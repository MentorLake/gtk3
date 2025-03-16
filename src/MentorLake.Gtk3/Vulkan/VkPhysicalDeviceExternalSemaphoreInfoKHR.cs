namespace MentorLake.Vulkan;

public class VkPhysicalDeviceExternalSemaphoreInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalSemaphoreInfoKHRExtensions
{

	public static VkPhysicalDeviceExternalSemaphoreInfoKHR Dereference(this VkPhysicalDeviceExternalSemaphoreInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalSemaphoreInfoKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalSemaphoreInfoKHRExterns
{
}

public struct VkPhysicalDeviceExternalSemaphoreInfoKHR
{
}

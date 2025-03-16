namespace MentorLake.Vulkan;

public class VkDeviceQueueGlobalPriorityCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceQueueGlobalPriorityCreateInfoKHRExtensions
{

	public static VkDeviceQueueGlobalPriorityCreateInfoKHR Dereference(this VkDeviceQueueGlobalPriorityCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceQueueGlobalPriorityCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceQueueGlobalPriorityCreateInfoKHRExterns
{
}

public struct VkDeviceQueueGlobalPriorityCreateInfoKHR
{
}

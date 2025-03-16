namespace MentorLake.Vulkan;

public class VkQueueGlobalPriorityKHRHandle : BaseSafeHandle
{
}


public static class VkQueueGlobalPriorityKHRExtensions
{

	public static VkQueueGlobalPriorityKHR Dereference(this VkQueueGlobalPriorityKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueGlobalPriorityKHR>(x.DangerousGetHandle());
}
internal class VkQueueGlobalPriorityKHRExterns
{
}

public struct VkQueueGlobalPriorityKHR
{
}

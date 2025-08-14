namespace MentorLake.Vulkan;


public class VkQueueGlobalPriorityEXTHandle : BaseSafeHandle
{
}


public static class VkQueueGlobalPriorityEXTExtensions
{

	public static VkQueueGlobalPriorityEXT Dereference(this VkQueueGlobalPriorityEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueGlobalPriorityEXT>(x.DangerousGetHandle());
}
internal class VkQueueGlobalPriorityEXTExterns
{
}


public struct VkQueueGlobalPriorityEXT
{
}

namespace MentorLake.Vulkan;


public class VkDeviceQueueGlobalPriorityCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceQueueGlobalPriorityCreateInfoEXTExtensions
{

	public static VkDeviceQueueGlobalPriorityCreateInfoEXT Dereference(this VkDeviceQueueGlobalPriorityCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceQueueGlobalPriorityCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkDeviceQueueGlobalPriorityCreateInfoEXTExterns
{
}


public struct VkDeviceQueueGlobalPriorityCreateInfoEXT
{
}

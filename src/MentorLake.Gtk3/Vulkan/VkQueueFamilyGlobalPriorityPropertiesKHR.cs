namespace MentorLake.Vulkan;

public class VkQueueFamilyGlobalPriorityPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkQueueFamilyGlobalPriorityPropertiesKHRExtensions
{

	public static VkQueueFamilyGlobalPriorityPropertiesKHR Dereference(this VkQueueFamilyGlobalPriorityPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFamilyGlobalPriorityPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkQueueFamilyGlobalPriorityPropertiesKHRExterns
{
}

public struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
}

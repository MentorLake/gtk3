namespace MentorLake.Vulkan;


public class VkQueueFamilyGlobalPriorityPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkQueueFamilyGlobalPriorityPropertiesEXTExtensions
{

	public static VkQueueFamilyGlobalPriorityPropertiesEXT Dereference(this VkQueueFamilyGlobalPriorityPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFamilyGlobalPriorityPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkQueueFamilyGlobalPriorityPropertiesEXTExterns
{
}


public struct VkQueueFamilyGlobalPriorityPropertiesEXT
{
}

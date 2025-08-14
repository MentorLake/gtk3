namespace MentorLake.Vulkan;


public class VkQueueFamilyQueryResultStatusPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkQueueFamilyQueryResultStatusPropertiesKHRExtensions
{

	public static VkQueueFamilyQueryResultStatusPropertiesKHR Dereference(this VkQueueFamilyQueryResultStatusPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFamilyQueryResultStatusPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkQueueFamilyQueryResultStatusPropertiesKHRExterns
{
}


public struct VkQueueFamilyQueryResultStatusPropertiesKHR
{
}

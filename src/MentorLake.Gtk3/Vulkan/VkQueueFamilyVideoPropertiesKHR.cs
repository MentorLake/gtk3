namespace MentorLake.Vulkan;

public class VkQueueFamilyVideoPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkQueueFamilyVideoPropertiesKHRExtensions
{

	public static VkQueueFamilyVideoPropertiesKHR Dereference(this VkQueueFamilyVideoPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFamilyVideoPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkQueueFamilyVideoPropertiesKHRExterns
{
}

public struct VkQueueFamilyVideoPropertiesKHR
{
}

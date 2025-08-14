namespace MentorLake.Vulkan;


public class VkQueueFamilyProperties2KHRHandle : BaseSafeHandle
{
}


public static class VkQueueFamilyProperties2KHRExtensions
{

	public static VkQueueFamilyProperties2KHR Dereference(this VkQueueFamilyProperties2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFamilyProperties2KHR>(x.DangerousGetHandle());
}
internal class VkQueueFamilyProperties2KHRExterns
{
}


public struct VkQueueFamilyProperties2KHR
{
}

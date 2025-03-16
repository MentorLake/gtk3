namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMemoryProperties2KHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMemoryProperties2KHRExtensions
{

	public static VkPhysicalDeviceMemoryProperties2KHR Dereference(this VkPhysicalDeviceMemoryProperties2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMemoryProperties2KHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMemoryProperties2KHRExterns
{
}

public struct VkPhysicalDeviceMemoryProperties2KHR
{
}

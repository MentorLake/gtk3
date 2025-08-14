namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMemoryProperties2Handle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMemoryProperties2Extensions
{

	public static VkPhysicalDeviceMemoryProperties2 Dereference(this VkPhysicalDeviceMemoryProperties2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMemoryProperties2>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMemoryProperties2Externs
{
}


public struct VkPhysicalDeviceMemoryProperties2
{
}

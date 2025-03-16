namespace MentorLake.Vulkan;

public class VkPhysicalDeviceProperties2KHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceProperties2KHRExtensions
{

	public static VkPhysicalDeviceProperties2KHR Dereference(this VkPhysicalDeviceProperties2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceProperties2KHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceProperties2KHRExterns
{
}

public struct VkPhysicalDeviceProperties2KHR
{
}

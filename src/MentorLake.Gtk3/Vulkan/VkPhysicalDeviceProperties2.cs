namespace MentorLake.Vulkan;

public class VkPhysicalDeviceProperties2Handle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceProperties2Extensions
{

	public static VkPhysicalDeviceProperties2 Dereference(this VkPhysicalDeviceProperties2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceProperties2>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceProperties2Externs
{
}

public struct VkPhysicalDeviceProperties2
{
}

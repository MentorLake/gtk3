namespace MentorLake.Vulkan;

public class VkPhysicalDeviceHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExtensions
{

	public static VkPhysicalDevice Dereference(this VkPhysicalDeviceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevice>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExterns
{
}

public struct VkPhysicalDevice
{
}

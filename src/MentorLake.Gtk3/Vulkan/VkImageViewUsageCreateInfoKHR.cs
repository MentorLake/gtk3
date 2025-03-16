namespace MentorLake.Vulkan;

public class VkImageViewUsageCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkImageViewUsageCreateInfoKHRExtensions
{

	public static VkImageViewUsageCreateInfoKHR Dereference(this VkImageViewUsageCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewUsageCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkImageViewUsageCreateInfoKHRExterns
{
}

public struct VkImageViewUsageCreateInfoKHR
{
}

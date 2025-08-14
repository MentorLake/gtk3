namespace MentorLake.Vulkan;


public class VkImageViewUsageCreateInfoHandle : BaseSafeHandle
{
}


public static class VkImageViewUsageCreateInfoExtensions
{

	public static VkImageViewUsageCreateInfo Dereference(this VkImageViewUsageCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewUsageCreateInfo>(x.DangerousGetHandle());
}
internal class VkImageViewUsageCreateInfoExterns
{
}


public struct VkImageViewUsageCreateInfo
{
}

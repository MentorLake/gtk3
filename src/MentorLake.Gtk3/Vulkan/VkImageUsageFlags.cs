namespace MentorLake.Vulkan;


public class VkImageUsageFlagsHandle : BaseSafeHandle
{
}


public static class VkImageUsageFlagsExtensions
{

	public static VkImageUsageFlags Dereference(this VkImageUsageFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageUsageFlags>(x.DangerousGetHandle());
}
internal class VkImageUsageFlagsExterns
{
}


public struct VkImageUsageFlags
{
}

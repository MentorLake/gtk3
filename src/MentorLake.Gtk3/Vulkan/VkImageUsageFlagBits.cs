namespace MentorLake.Vulkan;

public class VkImageUsageFlagBitsHandle : BaseSafeHandle
{
}


public static class VkImageUsageFlagBitsExtensions
{

	public static VkImageUsageFlagBits Dereference(this VkImageUsageFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageUsageFlagBits>(x.DangerousGetHandle());
}
internal class VkImageUsageFlagBitsExterns
{
}

public struct VkImageUsageFlagBits
{
}

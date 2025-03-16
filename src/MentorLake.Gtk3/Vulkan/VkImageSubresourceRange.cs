namespace MentorLake.Vulkan;

public class VkImageSubresourceRangeHandle : BaseSafeHandle
{
}


public static class VkImageSubresourceRangeExtensions
{

	public static VkImageSubresourceRange Dereference(this VkImageSubresourceRangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageSubresourceRange>(x.DangerousGetHandle());
}
internal class VkImageSubresourceRangeExterns
{
}

public struct VkImageSubresourceRange
{
}

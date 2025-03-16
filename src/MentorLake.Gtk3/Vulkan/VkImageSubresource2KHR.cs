namespace MentorLake.Vulkan;

public class VkImageSubresource2KHRHandle : BaseSafeHandle
{
}


public static class VkImageSubresource2KHRExtensions
{

	public static VkImageSubresource2KHR Dereference(this VkImageSubresource2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageSubresource2KHR>(x.DangerousGetHandle());
}
internal class VkImageSubresource2KHRExterns
{
}

public struct VkImageSubresource2KHR
{
}

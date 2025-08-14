namespace MentorLake.Vulkan;


public class VkImageSubresource2EXTHandle : BaseSafeHandle
{
}


public static class VkImageSubresource2EXTExtensions
{

	public static VkImageSubresource2EXT Dereference(this VkImageSubresource2EXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageSubresource2EXT>(x.DangerousGetHandle());
}
internal class VkImageSubresource2EXTExterns
{
}


public struct VkImageSubresource2EXT
{
}

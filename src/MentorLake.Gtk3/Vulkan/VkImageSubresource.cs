namespace MentorLake.Vulkan;


public class VkImageSubresourceHandle : BaseSafeHandle
{
}


public static class VkImageSubresourceExtensions
{

	public static VkImageSubresource Dereference(this VkImageSubresourceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageSubresource>(x.DangerousGetHandle());
}
internal class VkImageSubresourceExterns
{
}


public struct VkImageSubresource
{
}

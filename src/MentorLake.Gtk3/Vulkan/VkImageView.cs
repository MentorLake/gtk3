namespace MentorLake.Vulkan;

public class VkImageViewHandle : BaseSafeHandle
{
}


public static class VkImageViewExtensions
{

	public static VkImageView Dereference(this VkImageViewHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageView>(x.DangerousGetHandle());
}
internal class VkImageViewExterns
{
}

public struct VkImageView
{
}

namespace MentorLake.Vulkan;

public class VkImageCopyHandle : BaseSafeHandle
{
}


public static class VkImageCopyExtensions
{

	public static VkImageCopy Dereference(this VkImageCopyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCopy>(x.DangerousGetHandle());
}
internal class VkImageCopyExterns
{
}

public struct VkImageCopy
{
}

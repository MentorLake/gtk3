namespace MentorLake.Vulkan;


public class VkBufferImageCopyHandle : BaseSafeHandle
{
}


public static class VkBufferImageCopyExtensions
{

	public static VkBufferImageCopy Dereference(this VkBufferImageCopyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferImageCopy>(x.DangerousGetHandle());
}
internal class VkBufferImageCopyExterns
{
}


public struct VkBufferImageCopy
{
}

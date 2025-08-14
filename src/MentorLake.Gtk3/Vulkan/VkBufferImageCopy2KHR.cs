namespace MentorLake.Vulkan;


public class VkBufferImageCopy2KHRHandle : BaseSafeHandle
{
}


public static class VkBufferImageCopy2KHRExtensions
{

	public static VkBufferImageCopy2KHR Dereference(this VkBufferImageCopy2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferImageCopy2KHR>(x.DangerousGetHandle());
}
internal class VkBufferImageCopy2KHRExterns
{
}


public struct VkBufferImageCopy2KHR
{
}

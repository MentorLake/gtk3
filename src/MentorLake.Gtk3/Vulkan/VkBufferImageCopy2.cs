namespace MentorLake.Vulkan;

public class VkBufferImageCopy2Handle : BaseSafeHandle
{
}


public static class VkBufferImageCopy2Extensions
{

	public static VkBufferImageCopy2 Dereference(this VkBufferImageCopy2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferImageCopy2>(x.DangerousGetHandle());
}
internal class VkBufferImageCopy2Externs
{
}

public struct VkBufferImageCopy2
{
}

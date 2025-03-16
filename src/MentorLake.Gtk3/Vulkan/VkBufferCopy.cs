namespace MentorLake.Vulkan;

public class VkBufferCopyHandle : BaseSafeHandle
{
}


public static class VkBufferCopyExtensions
{

	public static VkBufferCopy Dereference(this VkBufferCopyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferCopy>(x.DangerousGetHandle());
}
internal class VkBufferCopyExterns
{
}

public struct VkBufferCopy
{
}

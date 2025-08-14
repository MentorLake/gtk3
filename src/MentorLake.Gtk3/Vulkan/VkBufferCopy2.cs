namespace MentorLake.Vulkan;


public class VkBufferCopy2Handle : BaseSafeHandle
{
}


public static class VkBufferCopy2Extensions
{

	public static VkBufferCopy2 Dereference(this VkBufferCopy2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferCopy2>(x.DangerousGetHandle());
}
internal class VkBufferCopy2Externs
{
}


public struct VkBufferCopy2
{
}

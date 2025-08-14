namespace MentorLake.Vulkan;


public class VkBufferCopy2KHRHandle : BaseSafeHandle
{
}


public static class VkBufferCopy2KHRExtensions
{

	public static VkBufferCopy2KHR Dereference(this VkBufferCopy2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferCopy2KHR>(x.DangerousGetHandle());
}
internal class VkBufferCopy2KHRExterns
{
}


public struct VkBufferCopy2KHR
{
}

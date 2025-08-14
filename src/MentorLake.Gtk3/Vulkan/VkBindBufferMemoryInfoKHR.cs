namespace MentorLake.Vulkan;


public class VkBindBufferMemoryInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBindBufferMemoryInfoKHRExtensions
{

	public static VkBindBufferMemoryInfoKHR Dereference(this VkBindBufferMemoryInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindBufferMemoryInfoKHR>(x.DangerousGetHandle());
}
internal class VkBindBufferMemoryInfoKHRExterns
{
}


public struct VkBindBufferMemoryInfoKHR
{
}

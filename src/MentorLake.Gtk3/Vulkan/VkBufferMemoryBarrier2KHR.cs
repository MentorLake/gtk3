namespace MentorLake.Vulkan;

public class VkBufferMemoryBarrier2KHRHandle : BaseSafeHandle
{
}


public static class VkBufferMemoryBarrier2KHRExtensions
{

	public static VkBufferMemoryBarrier2KHR Dereference(this VkBufferMemoryBarrier2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferMemoryBarrier2KHR>(x.DangerousGetHandle());
}
internal class VkBufferMemoryBarrier2KHRExterns
{
}

public struct VkBufferMemoryBarrier2KHR
{
}

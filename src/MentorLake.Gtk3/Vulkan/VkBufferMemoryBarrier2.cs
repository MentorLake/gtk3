namespace MentorLake.Vulkan;

public class VkBufferMemoryBarrier2Handle : BaseSafeHandle
{
}


public static class VkBufferMemoryBarrier2Extensions
{

	public static VkBufferMemoryBarrier2 Dereference(this VkBufferMemoryBarrier2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferMemoryBarrier2>(x.DangerousGetHandle());
}
internal class VkBufferMemoryBarrier2Externs
{
}

public struct VkBufferMemoryBarrier2
{
}

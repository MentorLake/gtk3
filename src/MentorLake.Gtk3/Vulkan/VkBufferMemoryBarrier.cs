namespace MentorLake.Vulkan;

public class VkBufferMemoryBarrierHandle : BaseSafeHandle
{
}


public static class VkBufferMemoryBarrierExtensions
{

	public static VkBufferMemoryBarrier Dereference(this VkBufferMemoryBarrierHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferMemoryBarrier>(x.DangerousGetHandle());
}
internal class VkBufferMemoryBarrierExterns
{
}

public struct VkBufferMemoryBarrier
{
}

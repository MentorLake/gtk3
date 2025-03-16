namespace MentorLake.Vulkan;

public class VkMemoryBarrierHandle : BaseSafeHandle
{
}


public static class VkMemoryBarrierExtensions
{

	public static VkMemoryBarrier Dereference(this VkMemoryBarrierHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryBarrier>(x.DangerousGetHandle());
}
internal class VkMemoryBarrierExterns
{
}

public struct VkMemoryBarrier
{
}

namespace MentorLake.Vulkan;


public class VkImageMemoryBarrierHandle : BaseSafeHandle
{
}


public static class VkImageMemoryBarrierExtensions
{

	public static VkImageMemoryBarrier Dereference(this VkImageMemoryBarrierHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageMemoryBarrier>(x.DangerousGetHandle());
}
internal class VkImageMemoryBarrierExterns
{
}


public struct VkImageMemoryBarrier
{
}

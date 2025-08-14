namespace MentorLake.Vulkan;


public class VkImageMemoryBarrier2KHRHandle : BaseSafeHandle
{
}


public static class VkImageMemoryBarrier2KHRExtensions
{

	public static VkImageMemoryBarrier2KHR Dereference(this VkImageMemoryBarrier2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageMemoryBarrier2KHR>(x.DangerousGetHandle());
}
internal class VkImageMemoryBarrier2KHRExterns
{
}


public struct VkImageMemoryBarrier2KHR
{
}

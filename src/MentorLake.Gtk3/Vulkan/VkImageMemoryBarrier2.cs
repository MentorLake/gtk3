namespace MentorLake.Vulkan;


public class VkImageMemoryBarrier2Handle : BaseSafeHandle
{
}


public static class VkImageMemoryBarrier2Extensions
{

	public static VkImageMemoryBarrier2 Dereference(this VkImageMemoryBarrier2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageMemoryBarrier2>(x.DangerousGetHandle());
}
internal class VkImageMemoryBarrier2Externs
{
}


public struct VkImageMemoryBarrier2
{
}

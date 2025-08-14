namespace MentorLake.Vulkan;


public class VkMemoryBarrier2KHRHandle : BaseSafeHandle
{
}


public static class VkMemoryBarrier2KHRExtensions
{

	public static VkMemoryBarrier2KHR Dereference(this VkMemoryBarrier2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryBarrier2KHR>(x.DangerousGetHandle());
}
internal class VkMemoryBarrier2KHRExterns
{
}


public struct VkMemoryBarrier2KHR
{
}

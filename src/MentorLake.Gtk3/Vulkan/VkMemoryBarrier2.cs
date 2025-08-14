namespace MentorLake.Vulkan;


public class VkMemoryBarrier2Handle : BaseSafeHandle
{
}


public static class VkMemoryBarrier2Extensions
{

	public static VkMemoryBarrier2 Dereference(this VkMemoryBarrier2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryBarrier2>(x.DangerousGetHandle());
}
internal class VkMemoryBarrier2Externs
{
}


public struct VkMemoryBarrier2
{
}

namespace MentorLake.Vulkan;


public class VkMemoryUnmapFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryUnmapFlagBitsKHRExtensions
{

	public static VkMemoryUnmapFlagBitsKHR Dereference(this VkMemoryUnmapFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryUnmapFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkMemoryUnmapFlagBitsKHRExterns
{
}


public struct VkMemoryUnmapFlagBitsKHR
{
}

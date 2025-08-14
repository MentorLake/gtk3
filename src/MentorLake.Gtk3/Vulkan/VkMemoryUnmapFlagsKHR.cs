namespace MentorLake.Vulkan;


public class VkMemoryUnmapFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryUnmapFlagsKHRExtensions
{

	public static VkMemoryUnmapFlagsKHR Dereference(this VkMemoryUnmapFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryUnmapFlagsKHR>(x.DangerousGetHandle());
}
internal class VkMemoryUnmapFlagsKHRExterns
{
}


public struct VkMemoryUnmapFlagsKHR
{
}

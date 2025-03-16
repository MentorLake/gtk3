namespace MentorLake.Vulkan;

public class VkMemoryUnmapInfoKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryUnmapInfoKHRExtensions
{

	public static VkMemoryUnmapInfoKHR Dereference(this VkMemoryUnmapInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryUnmapInfoKHR>(x.DangerousGetHandle());
}
internal class VkMemoryUnmapInfoKHRExterns
{
}

public struct VkMemoryUnmapInfoKHR
{
}

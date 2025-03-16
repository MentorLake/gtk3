namespace MentorLake.Vulkan;

public class VkBindImageMemoryInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBindImageMemoryInfoKHRExtensions
{

	public static VkBindImageMemoryInfoKHR Dereference(this VkBindImageMemoryInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindImageMemoryInfoKHR>(x.DangerousGetHandle());
}
internal class VkBindImageMemoryInfoKHRExterns
{
}

public struct VkBindImageMemoryInfoKHR
{
}

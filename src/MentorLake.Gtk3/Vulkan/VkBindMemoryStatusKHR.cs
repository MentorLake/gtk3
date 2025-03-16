namespace MentorLake.Vulkan;

public class VkBindMemoryStatusKHRHandle : BaseSafeHandle
{
}


public static class VkBindMemoryStatusKHRExtensions
{

	public static VkBindMemoryStatusKHR Dereference(this VkBindMemoryStatusKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindMemoryStatusKHR>(x.DangerousGetHandle());
}
internal class VkBindMemoryStatusKHRExterns
{
}

public struct VkBindMemoryStatusKHR
{
}

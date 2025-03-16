namespace MentorLake.Vulkan;

public class VkBindVideoSessionMemoryInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBindVideoSessionMemoryInfoKHRExtensions
{

	public static VkBindVideoSessionMemoryInfoKHR Dereference(this VkBindVideoSessionMemoryInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindVideoSessionMemoryInfoKHR>(x.DangerousGetHandle());
}
internal class VkBindVideoSessionMemoryInfoKHRExterns
{
}

public struct VkBindVideoSessionMemoryInfoKHR
{
}

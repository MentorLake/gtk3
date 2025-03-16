namespace MentorLake.Vulkan;

public class VkQueueFlagsHandle : BaseSafeHandle
{
}


public static class VkQueueFlagsExtensions
{

	public static VkQueueFlags Dereference(this VkQueueFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFlags>(x.DangerousGetHandle());
}
internal class VkQueueFlagsExterns
{
}

public struct VkQueueFlags
{
}

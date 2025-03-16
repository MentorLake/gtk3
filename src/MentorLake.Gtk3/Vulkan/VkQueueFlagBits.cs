namespace MentorLake.Vulkan;

public class VkQueueFlagBitsHandle : BaseSafeHandle
{
}


public static class VkQueueFlagBitsExtensions
{

	public static VkQueueFlagBits Dereference(this VkQueueFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFlagBits>(x.DangerousGetHandle());
}
internal class VkQueueFlagBitsExterns
{
}

public struct VkQueueFlagBits
{
}

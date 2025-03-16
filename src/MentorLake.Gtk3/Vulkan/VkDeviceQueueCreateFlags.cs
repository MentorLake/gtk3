namespace MentorLake.Vulkan;

public class VkDeviceQueueCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkDeviceQueueCreateFlagsExtensions
{

	public static VkDeviceQueueCreateFlags Dereference(this VkDeviceQueueCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceQueueCreateFlags>(x.DangerousGetHandle());
}
internal class VkDeviceQueueCreateFlagsExterns
{
}

public struct VkDeviceQueueCreateFlags
{
}

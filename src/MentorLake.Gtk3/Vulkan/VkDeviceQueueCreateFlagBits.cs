namespace MentorLake.Vulkan;

public class VkDeviceQueueCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkDeviceQueueCreateFlagBitsExtensions
{

	public static VkDeviceQueueCreateFlagBits Dereference(this VkDeviceQueueCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceQueueCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkDeviceQueueCreateFlagBitsExterns
{
}

public struct VkDeviceQueueCreateFlagBits
{
}

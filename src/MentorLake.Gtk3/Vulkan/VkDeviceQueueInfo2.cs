namespace MentorLake.Vulkan;


public class VkDeviceQueueInfo2Handle : BaseSafeHandle
{
}


public static class VkDeviceQueueInfo2Extensions
{

	public static VkDeviceQueueInfo2 Dereference(this VkDeviceQueueInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceQueueInfo2>(x.DangerousGetHandle());
}
internal class VkDeviceQueueInfo2Externs
{
}


public struct VkDeviceQueueInfo2
{
}

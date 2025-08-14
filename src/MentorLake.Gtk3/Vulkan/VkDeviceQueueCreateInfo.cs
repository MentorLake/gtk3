namespace MentorLake.Vulkan;


public class VkDeviceQueueCreateInfoHandle : BaseSafeHandle
{
}


public static class VkDeviceQueueCreateInfoExtensions
{

	public static VkDeviceQueueCreateInfo Dereference(this VkDeviceQueueCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceQueueCreateInfo>(x.DangerousGetHandle());
}
internal class VkDeviceQueueCreateInfoExterns
{
}


public struct VkDeviceQueueCreateInfo
{
}

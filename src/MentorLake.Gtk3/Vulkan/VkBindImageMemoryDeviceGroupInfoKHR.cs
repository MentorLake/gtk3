namespace MentorLake.Vulkan;


public class VkBindImageMemoryDeviceGroupInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBindImageMemoryDeviceGroupInfoKHRExtensions
{

	public static VkBindImageMemoryDeviceGroupInfoKHR Dereference(this VkBindImageMemoryDeviceGroupInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindImageMemoryDeviceGroupInfoKHR>(x.DangerousGetHandle());
}
internal class VkBindImageMemoryDeviceGroupInfoKHRExterns
{
}


public struct VkBindImageMemoryDeviceGroupInfoKHR
{
}

namespace MentorLake.Vulkan;


public class VkBindBufferMemoryDeviceGroupInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBindBufferMemoryDeviceGroupInfoKHRExtensions
{

	public static VkBindBufferMemoryDeviceGroupInfoKHR Dereference(this VkBindBufferMemoryDeviceGroupInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindBufferMemoryDeviceGroupInfoKHR>(x.DangerousGetHandle());
}
internal class VkBindBufferMemoryDeviceGroupInfoKHRExterns
{
}


public struct VkBindBufferMemoryDeviceGroupInfoKHR
{
}

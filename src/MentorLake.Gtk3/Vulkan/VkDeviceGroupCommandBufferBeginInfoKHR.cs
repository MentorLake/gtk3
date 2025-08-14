namespace MentorLake.Vulkan;


public class VkDeviceGroupCommandBufferBeginInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupCommandBufferBeginInfoKHRExtensions
{

	public static VkDeviceGroupCommandBufferBeginInfoKHR Dereference(this VkDeviceGroupCommandBufferBeginInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupCommandBufferBeginInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupCommandBufferBeginInfoKHRExterns
{
}


public struct VkDeviceGroupCommandBufferBeginInfoKHR
{
}

namespace MentorLake.Vulkan;


public class VkDeviceImageSubresourceInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceImageSubresourceInfoKHRExtensions
{

	public static VkDeviceImageSubresourceInfoKHR Dereference(this VkDeviceImageSubresourceInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceImageSubresourceInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceImageSubresourceInfoKHRExterns
{
}


public struct VkDeviceImageSubresourceInfoKHR
{
}

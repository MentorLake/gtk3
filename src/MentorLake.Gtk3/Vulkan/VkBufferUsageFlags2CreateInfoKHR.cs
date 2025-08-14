namespace MentorLake.Vulkan;


public class VkBufferUsageFlags2CreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBufferUsageFlags2CreateInfoKHRExtensions
{

	public static VkBufferUsageFlags2CreateInfoKHR Dereference(this VkBufferUsageFlags2CreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferUsageFlags2CreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkBufferUsageFlags2CreateInfoKHRExterns
{
}


public struct VkBufferUsageFlags2CreateInfoKHR
{
}

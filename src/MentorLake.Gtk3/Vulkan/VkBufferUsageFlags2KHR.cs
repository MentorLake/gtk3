namespace MentorLake.Vulkan;


public class VkBufferUsageFlags2KHRHandle : BaseSafeHandle
{
}


public static class VkBufferUsageFlags2KHRExtensions
{

	public static VkBufferUsageFlags2KHR Dereference(this VkBufferUsageFlags2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferUsageFlags2KHR>(x.DangerousGetHandle());
}
internal class VkBufferUsageFlags2KHRExterns
{
}


public struct VkBufferUsageFlags2KHR
{
}

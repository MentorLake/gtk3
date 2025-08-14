namespace MentorLake.Vulkan;


public class VkBufferUsageFlagBits2KHRHandle : BaseSafeHandle
{
}


public static class VkBufferUsageFlagBits2KHRExtensions
{

	public static VkBufferUsageFlagBits2KHR Dereference(this VkBufferUsageFlagBits2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferUsageFlagBits2KHR>(x.DangerousGetHandle());
}
internal class VkBufferUsageFlagBits2KHRExterns
{
}


public struct VkBufferUsageFlagBits2KHR
{
}

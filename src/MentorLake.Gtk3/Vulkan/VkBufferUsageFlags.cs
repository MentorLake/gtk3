namespace MentorLake.Vulkan;


public class VkBufferUsageFlagsHandle : BaseSafeHandle
{
}


public static class VkBufferUsageFlagsExtensions
{

	public static VkBufferUsageFlags Dereference(this VkBufferUsageFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferUsageFlags>(x.DangerousGetHandle());
}
internal class VkBufferUsageFlagsExterns
{
}


public struct VkBufferUsageFlags
{
}

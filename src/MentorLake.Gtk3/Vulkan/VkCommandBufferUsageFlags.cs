namespace MentorLake.Vulkan;

public class VkCommandBufferUsageFlagsHandle : BaseSafeHandle
{
}


public static class VkCommandBufferUsageFlagsExtensions
{

	public static VkCommandBufferUsageFlags Dereference(this VkCommandBufferUsageFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferUsageFlags>(x.DangerousGetHandle());
}
internal class VkCommandBufferUsageFlagsExterns
{
}

public struct VkCommandBufferUsageFlags
{
}

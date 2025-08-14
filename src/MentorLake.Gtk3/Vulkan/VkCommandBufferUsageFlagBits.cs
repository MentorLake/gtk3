namespace MentorLake.Vulkan;


public class VkCommandBufferUsageFlagBitsHandle : BaseSafeHandle
{
}


public static class VkCommandBufferUsageFlagBitsExtensions
{

	public static VkCommandBufferUsageFlagBits Dereference(this VkCommandBufferUsageFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferUsageFlagBits>(x.DangerousGetHandle());
}
internal class VkCommandBufferUsageFlagBitsExterns
{
}


public struct VkCommandBufferUsageFlagBits
{
}

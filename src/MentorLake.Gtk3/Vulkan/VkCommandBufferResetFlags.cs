namespace MentorLake.Vulkan;


public class VkCommandBufferResetFlagsHandle : BaseSafeHandle
{
}


public static class VkCommandBufferResetFlagsExtensions
{

	public static VkCommandBufferResetFlags Dereference(this VkCommandBufferResetFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferResetFlags>(x.DangerousGetHandle());
}
internal class VkCommandBufferResetFlagsExterns
{
}


public struct VkCommandBufferResetFlags
{
}

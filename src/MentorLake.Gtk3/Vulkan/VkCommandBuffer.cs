namespace MentorLake.Vulkan;

public class VkCommandBufferHandle : BaseSafeHandle
{
}


public static class VkCommandBufferExtensions
{

	public static VkCommandBuffer Dereference(this VkCommandBufferHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBuffer>(x.DangerousGetHandle());
}
internal class VkCommandBufferExterns
{
}

public struct VkCommandBuffer
{
}

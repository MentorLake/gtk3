namespace MentorLake.Vulkan;

public class VkCommandBufferLevelHandle : BaseSafeHandle
{
}


public static class VkCommandBufferLevelExtensions
{

	public static VkCommandBufferLevel Dereference(this VkCommandBufferLevelHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferLevel>(x.DangerousGetHandle());
}
internal class VkCommandBufferLevelExterns
{
}

public struct VkCommandBufferLevel
{
}

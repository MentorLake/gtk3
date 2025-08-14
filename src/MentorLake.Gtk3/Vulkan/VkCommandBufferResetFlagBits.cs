namespace MentorLake.Vulkan;


public class VkCommandBufferResetFlagBitsHandle : BaseSafeHandle
{
}


public static class VkCommandBufferResetFlagBitsExtensions
{

	public static VkCommandBufferResetFlagBits Dereference(this VkCommandBufferResetFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferResetFlagBits>(x.DangerousGetHandle());
}
internal class VkCommandBufferResetFlagBitsExterns
{
}


public struct VkCommandBufferResetFlagBits
{
}

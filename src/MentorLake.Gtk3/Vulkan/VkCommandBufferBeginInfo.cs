namespace MentorLake.Vulkan;


public class VkCommandBufferBeginInfoHandle : BaseSafeHandle
{
}


public static class VkCommandBufferBeginInfoExtensions
{

	public static VkCommandBufferBeginInfo Dereference(this VkCommandBufferBeginInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferBeginInfo>(x.DangerousGetHandle());
}
internal class VkCommandBufferBeginInfoExterns
{
}


public struct VkCommandBufferBeginInfo
{
}

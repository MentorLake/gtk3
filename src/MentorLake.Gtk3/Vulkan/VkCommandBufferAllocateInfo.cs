namespace MentorLake.Vulkan;


public class VkCommandBufferAllocateInfoHandle : BaseSafeHandle
{
}


public static class VkCommandBufferAllocateInfoExtensions
{

	public static VkCommandBufferAllocateInfo Dereference(this VkCommandBufferAllocateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferAllocateInfo>(x.DangerousGetHandle());
}
internal class VkCommandBufferAllocateInfoExterns
{
}


public struct VkCommandBufferAllocateInfo
{
}

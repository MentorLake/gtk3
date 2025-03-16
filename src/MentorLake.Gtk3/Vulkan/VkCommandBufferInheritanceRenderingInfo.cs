namespace MentorLake.Vulkan;

public class VkCommandBufferInheritanceRenderingInfoHandle : BaseSafeHandle
{
}


public static class VkCommandBufferInheritanceRenderingInfoExtensions
{

	public static VkCommandBufferInheritanceRenderingInfo Dereference(this VkCommandBufferInheritanceRenderingInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferInheritanceRenderingInfo>(x.DangerousGetHandle());
}
internal class VkCommandBufferInheritanceRenderingInfoExterns
{
}

public struct VkCommandBufferInheritanceRenderingInfo
{
}

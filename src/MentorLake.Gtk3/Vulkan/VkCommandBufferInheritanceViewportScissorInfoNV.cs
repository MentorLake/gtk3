namespace MentorLake.Vulkan;

public class VkCommandBufferInheritanceViewportScissorInfoNVHandle : BaseSafeHandle
{
}


public static class VkCommandBufferInheritanceViewportScissorInfoNVExtensions
{

	public static VkCommandBufferInheritanceViewportScissorInfoNV Dereference(this VkCommandBufferInheritanceViewportScissorInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferInheritanceViewportScissorInfoNV>(x.DangerousGetHandle());
}
internal class VkCommandBufferInheritanceViewportScissorInfoNVExterns
{
}

public struct VkCommandBufferInheritanceViewportScissorInfoNV
{
}

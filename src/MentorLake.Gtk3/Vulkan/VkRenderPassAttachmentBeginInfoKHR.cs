namespace MentorLake.Vulkan;


public class VkRenderPassAttachmentBeginInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRenderPassAttachmentBeginInfoKHRExtensions
{

	public static VkRenderPassAttachmentBeginInfoKHR Dereference(this VkRenderPassAttachmentBeginInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassAttachmentBeginInfoKHR>(x.DangerousGetHandle());
}
internal class VkRenderPassAttachmentBeginInfoKHRExterns
{
}


public struct VkRenderPassAttachmentBeginInfoKHR
{
}

namespace MentorLake.Vulkan;


public class VkRenderPassAttachmentBeginInfoHandle : BaseSafeHandle
{
}


public static class VkRenderPassAttachmentBeginInfoExtensions
{

	public static VkRenderPassAttachmentBeginInfo Dereference(this VkRenderPassAttachmentBeginInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassAttachmentBeginInfo>(x.DangerousGetHandle());
}
internal class VkRenderPassAttachmentBeginInfoExterns
{
}


public struct VkRenderPassAttachmentBeginInfo
{
}

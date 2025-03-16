namespace MentorLake.Vulkan;

public class VkRenderingAttachmentInfoHandle : BaseSafeHandle
{
}


public static class VkRenderingAttachmentInfoExtensions
{

	public static VkRenderingAttachmentInfo Dereference(this VkRenderingAttachmentInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingAttachmentInfo>(x.DangerousGetHandle());
}
internal class VkRenderingAttachmentInfoExterns
{
}

public struct VkRenderingAttachmentInfo
{
}

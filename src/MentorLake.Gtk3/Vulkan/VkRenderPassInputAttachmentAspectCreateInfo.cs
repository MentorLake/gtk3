namespace MentorLake.Vulkan;

public class VkRenderPassInputAttachmentAspectCreateInfoHandle : BaseSafeHandle
{
}


public static class VkRenderPassInputAttachmentAspectCreateInfoExtensions
{

	public static VkRenderPassInputAttachmentAspectCreateInfo Dereference(this VkRenderPassInputAttachmentAspectCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassInputAttachmentAspectCreateInfo>(x.DangerousGetHandle());
}
internal class VkRenderPassInputAttachmentAspectCreateInfoExterns
{
}

public struct VkRenderPassInputAttachmentAspectCreateInfo
{
}

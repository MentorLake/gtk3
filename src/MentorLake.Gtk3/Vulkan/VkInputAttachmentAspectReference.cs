namespace MentorLake.Vulkan;

public class VkInputAttachmentAspectReferenceHandle : BaseSafeHandle
{
}


public static class VkInputAttachmentAspectReferenceExtensions
{

	public static VkInputAttachmentAspectReference Dereference(this VkInputAttachmentAspectReferenceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkInputAttachmentAspectReference>(x.DangerousGetHandle());
}
internal class VkInputAttachmentAspectReferenceExterns
{
}

public struct VkInputAttachmentAspectReference
{
}

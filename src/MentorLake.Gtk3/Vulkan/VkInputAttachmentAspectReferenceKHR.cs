namespace MentorLake.Vulkan;

public class VkInputAttachmentAspectReferenceKHRHandle : BaseSafeHandle
{
}


public static class VkInputAttachmentAspectReferenceKHRExtensions
{

	public static VkInputAttachmentAspectReferenceKHR Dereference(this VkInputAttachmentAspectReferenceKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkInputAttachmentAspectReferenceKHR>(x.DangerousGetHandle());
}
internal class VkInputAttachmentAspectReferenceKHRExterns
{
}

public struct VkInputAttachmentAspectReferenceKHR
{
}

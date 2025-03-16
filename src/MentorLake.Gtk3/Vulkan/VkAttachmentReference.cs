namespace MentorLake.Vulkan;

public class VkAttachmentReferenceHandle : BaseSafeHandle
{
}


public static class VkAttachmentReferenceExtensions
{

	public static VkAttachmentReference Dereference(this VkAttachmentReferenceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentReference>(x.DangerousGetHandle());
}
internal class VkAttachmentReferenceExterns
{
}

public struct VkAttachmentReference
{
}

namespace MentorLake.Vulkan;


public class VkAttachmentSampleCountInfoNVHandle : BaseSafeHandle
{
}


public static class VkAttachmentSampleCountInfoNVExtensions
{

	public static VkAttachmentSampleCountInfoNV Dereference(this VkAttachmentSampleCountInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentSampleCountInfoNV>(x.DangerousGetHandle());
}
internal class VkAttachmentSampleCountInfoNVExterns
{
}


public struct VkAttachmentSampleCountInfoNV
{
}

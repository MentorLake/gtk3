namespace MentorLake.Vulkan;


public class VkClearAttachmentHandle : BaseSafeHandle
{
}


public static class VkClearAttachmentExtensions
{

	public static VkClearAttachment Dereference(this VkClearAttachmentHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkClearAttachment>(x.DangerousGetHandle());
}
internal class VkClearAttachmentExterns
{
}


public struct VkClearAttachment
{
}

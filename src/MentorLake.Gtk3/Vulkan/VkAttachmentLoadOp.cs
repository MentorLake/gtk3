namespace MentorLake.Vulkan;


public class VkAttachmentLoadOpHandle : BaseSafeHandle
{
}


public static class VkAttachmentLoadOpExtensions
{

	public static VkAttachmentLoadOp Dereference(this VkAttachmentLoadOpHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentLoadOp>(x.DangerousGetHandle());
}
internal class VkAttachmentLoadOpExterns
{
}


public struct VkAttachmentLoadOp
{
}

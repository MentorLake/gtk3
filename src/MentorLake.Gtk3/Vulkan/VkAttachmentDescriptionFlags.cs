namespace MentorLake.Vulkan;


public class VkAttachmentDescriptionFlagsHandle : BaseSafeHandle
{
}


public static class VkAttachmentDescriptionFlagsExtensions
{

	public static VkAttachmentDescriptionFlags Dereference(this VkAttachmentDescriptionFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentDescriptionFlags>(x.DangerousGetHandle());
}
internal class VkAttachmentDescriptionFlagsExterns
{
}


public struct VkAttachmentDescriptionFlags
{
}

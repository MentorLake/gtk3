namespace MentorLake.Vulkan;

public class VkAttachmentDescriptionFlagBitsHandle : BaseSafeHandle
{
}


public static class VkAttachmentDescriptionFlagBitsExtensions
{

	public static VkAttachmentDescriptionFlagBits Dereference(this VkAttachmentDescriptionFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentDescriptionFlagBits>(x.DangerousGetHandle());
}
internal class VkAttachmentDescriptionFlagBitsExterns
{
}

public struct VkAttachmentDescriptionFlagBits
{
}

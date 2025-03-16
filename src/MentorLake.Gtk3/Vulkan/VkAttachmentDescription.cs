namespace MentorLake.Vulkan;

public class VkAttachmentDescriptionHandle : BaseSafeHandle
{
}


public static class VkAttachmentDescriptionExtensions
{

	public static VkAttachmentDescription Dereference(this VkAttachmentDescriptionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentDescription>(x.DangerousGetHandle());
}
internal class VkAttachmentDescriptionExterns
{
}

public struct VkAttachmentDescription
{
}

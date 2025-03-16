namespace MentorLake.Vulkan;

public class VkAttachmentDescription2Handle : BaseSafeHandle
{
}


public static class VkAttachmentDescription2Extensions
{

	public static VkAttachmentDescription2 Dereference(this VkAttachmentDescription2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentDescription2>(x.DangerousGetHandle());
}
internal class VkAttachmentDescription2Externs
{
}

public struct VkAttachmentDescription2
{
}

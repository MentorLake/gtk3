namespace MentorLake.Vulkan;


public class VkAttachmentReference2Handle : BaseSafeHandle
{
}


public static class VkAttachmentReference2Extensions
{

	public static VkAttachmentReference2 Dereference(this VkAttachmentReference2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentReference2>(x.DangerousGetHandle());
}
internal class VkAttachmentReference2Externs
{
}


public struct VkAttachmentReference2
{
}

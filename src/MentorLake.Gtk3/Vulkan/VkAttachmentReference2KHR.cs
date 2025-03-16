namespace MentorLake.Vulkan;

public class VkAttachmentReference2KHRHandle : BaseSafeHandle
{
}


public static class VkAttachmentReference2KHRExtensions
{

	public static VkAttachmentReference2KHR Dereference(this VkAttachmentReference2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentReference2KHR>(x.DangerousGetHandle());
}
internal class VkAttachmentReference2KHRExterns
{
}

public struct VkAttachmentReference2KHR
{
}

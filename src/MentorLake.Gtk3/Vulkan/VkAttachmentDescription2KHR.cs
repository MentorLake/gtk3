namespace MentorLake.Vulkan;

public class VkAttachmentDescription2KHRHandle : BaseSafeHandle
{
}


public static class VkAttachmentDescription2KHRExtensions
{

	public static VkAttachmentDescription2KHR Dereference(this VkAttachmentDescription2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentDescription2KHR>(x.DangerousGetHandle());
}
internal class VkAttachmentDescription2KHRExterns
{
}

public struct VkAttachmentDescription2KHR
{
}

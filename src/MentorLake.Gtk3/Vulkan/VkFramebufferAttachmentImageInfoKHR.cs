namespace MentorLake.Vulkan;

public class VkFramebufferAttachmentImageInfoKHRHandle : BaseSafeHandle
{
}


public static class VkFramebufferAttachmentImageInfoKHRExtensions
{

	public static VkFramebufferAttachmentImageInfoKHR Dereference(this VkFramebufferAttachmentImageInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFramebufferAttachmentImageInfoKHR>(x.DangerousGetHandle());
}
internal class VkFramebufferAttachmentImageInfoKHRExterns
{
}

public struct VkFramebufferAttachmentImageInfoKHR
{
}

namespace MentorLake.Vulkan;


public class VkFramebufferAttachmentImageInfoHandle : BaseSafeHandle
{
}


public static class VkFramebufferAttachmentImageInfoExtensions
{

	public static VkFramebufferAttachmentImageInfo Dereference(this VkFramebufferAttachmentImageInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFramebufferAttachmentImageInfo>(x.DangerousGetHandle());
}
internal class VkFramebufferAttachmentImageInfoExterns
{
}


public struct VkFramebufferAttachmentImageInfo
{
}

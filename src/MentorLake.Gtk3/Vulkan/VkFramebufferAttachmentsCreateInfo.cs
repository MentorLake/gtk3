namespace MentorLake.Vulkan;

public class VkFramebufferAttachmentsCreateInfoHandle : BaseSafeHandle
{
}


public static class VkFramebufferAttachmentsCreateInfoExtensions
{

	public static VkFramebufferAttachmentsCreateInfo Dereference(this VkFramebufferAttachmentsCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFramebufferAttachmentsCreateInfo>(x.DangerousGetHandle());
}
internal class VkFramebufferAttachmentsCreateInfoExterns
{
}

public struct VkFramebufferAttachmentsCreateInfo
{
}

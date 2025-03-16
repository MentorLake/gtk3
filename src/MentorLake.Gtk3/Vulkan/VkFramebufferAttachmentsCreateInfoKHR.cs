namespace MentorLake.Vulkan;

public class VkFramebufferAttachmentsCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkFramebufferAttachmentsCreateInfoKHRExtensions
{

	public static VkFramebufferAttachmentsCreateInfoKHR Dereference(this VkFramebufferAttachmentsCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFramebufferAttachmentsCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkFramebufferAttachmentsCreateInfoKHRExterns
{
}

public struct VkFramebufferAttachmentsCreateInfoKHR
{
}

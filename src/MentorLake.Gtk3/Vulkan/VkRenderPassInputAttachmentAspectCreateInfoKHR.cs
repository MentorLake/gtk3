namespace MentorLake.Vulkan;

public class VkRenderPassInputAttachmentAspectCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRenderPassInputAttachmentAspectCreateInfoKHRExtensions
{

	public static VkRenderPassInputAttachmentAspectCreateInfoKHR Dereference(this VkRenderPassInputAttachmentAspectCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassInputAttachmentAspectCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkRenderPassInputAttachmentAspectCreateInfoKHRExterns
{
}

public struct VkRenderPassInputAttachmentAspectCreateInfoKHR
{
}

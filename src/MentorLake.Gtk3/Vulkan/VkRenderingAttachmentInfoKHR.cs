namespace MentorLake.Vulkan;

public class VkRenderingAttachmentInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRenderingAttachmentInfoKHRExtensions
{

	public static VkRenderingAttachmentInfoKHR Dereference(this VkRenderingAttachmentInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingAttachmentInfoKHR>(x.DangerousGetHandle());
}
internal class VkRenderingAttachmentInfoKHRExterns
{
}

public struct VkRenderingAttachmentInfoKHR
{
}

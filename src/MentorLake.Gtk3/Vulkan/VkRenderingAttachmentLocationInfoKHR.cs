namespace MentorLake.Vulkan;


public class VkRenderingAttachmentLocationInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRenderingAttachmentLocationInfoKHRExtensions
{

	public static VkRenderingAttachmentLocationInfoKHR Dereference(this VkRenderingAttachmentLocationInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingAttachmentLocationInfoKHR>(x.DangerousGetHandle());
}
internal class VkRenderingAttachmentLocationInfoKHRExterns
{
}


public struct VkRenderingAttachmentLocationInfoKHR
{
}

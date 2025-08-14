namespace MentorLake.Vulkan;


public class VkRenderingInputAttachmentIndexInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRenderingInputAttachmentIndexInfoKHRExtensions
{

	public static VkRenderingInputAttachmentIndexInfoKHR Dereference(this VkRenderingInputAttachmentIndexInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingInputAttachmentIndexInfoKHR>(x.DangerousGetHandle());
}
internal class VkRenderingInputAttachmentIndexInfoKHRExterns
{
}


public struct VkRenderingInputAttachmentIndexInfoKHR
{
}

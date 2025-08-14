namespace MentorLake.Vulkan;


public class VkAttachmentReferenceStencilLayoutKHRHandle : BaseSafeHandle
{
}


public static class VkAttachmentReferenceStencilLayoutKHRExtensions
{

	public static VkAttachmentReferenceStencilLayoutKHR Dereference(this VkAttachmentReferenceStencilLayoutKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentReferenceStencilLayoutKHR>(x.DangerousGetHandle());
}
internal class VkAttachmentReferenceStencilLayoutKHRExterns
{
}


public struct VkAttachmentReferenceStencilLayoutKHR
{
}

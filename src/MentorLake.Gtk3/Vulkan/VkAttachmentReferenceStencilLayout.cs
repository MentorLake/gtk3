namespace MentorLake.Vulkan;


public class VkAttachmentReferenceStencilLayoutHandle : BaseSafeHandle
{
}


public static class VkAttachmentReferenceStencilLayoutExtensions
{

	public static VkAttachmentReferenceStencilLayout Dereference(this VkAttachmentReferenceStencilLayoutHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentReferenceStencilLayout>(x.DangerousGetHandle());
}
internal class VkAttachmentReferenceStencilLayoutExterns
{
}


public struct VkAttachmentReferenceStencilLayout
{
}

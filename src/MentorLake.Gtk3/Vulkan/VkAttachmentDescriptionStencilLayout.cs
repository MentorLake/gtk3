namespace MentorLake.Vulkan;

public class VkAttachmentDescriptionStencilLayoutHandle : BaseSafeHandle
{
}


public static class VkAttachmentDescriptionStencilLayoutExtensions
{

	public static VkAttachmentDescriptionStencilLayout Dereference(this VkAttachmentDescriptionStencilLayoutHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentDescriptionStencilLayout>(x.DangerousGetHandle());
}
internal class VkAttachmentDescriptionStencilLayoutExterns
{
}

public struct VkAttachmentDescriptionStencilLayout
{
}

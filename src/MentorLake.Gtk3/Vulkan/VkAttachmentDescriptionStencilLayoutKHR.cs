namespace MentorLake.Vulkan;

public class VkAttachmentDescriptionStencilLayoutKHRHandle : BaseSafeHandle
{
}


public static class VkAttachmentDescriptionStencilLayoutKHRExtensions
{

	public static VkAttachmentDescriptionStencilLayoutKHR Dereference(this VkAttachmentDescriptionStencilLayoutKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentDescriptionStencilLayoutKHR>(x.DangerousGetHandle());
}
internal class VkAttachmentDescriptionStencilLayoutKHRExterns
{
}

public struct VkAttachmentDescriptionStencilLayoutKHR
{
}

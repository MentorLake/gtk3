namespace MentorLake.Vulkan;

public class VkAttachmentStoreOpHandle : BaseSafeHandle
{
}


public static class VkAttachmentStoreOpExtensions
{

	public static VkAttachmentStoreOp Dereference(this VkAttachmentStoreOpHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentStoreOp>(x.DangerousGetHandle());
}
internal class VkAttachmentStoreOpExterns
{
}

public struct VkAttachmentStoreOp
{
}

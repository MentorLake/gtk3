namespace MentorLake.Vulkan;


public class VkAttachmentSampleCountInfoAMDHandle : BaseSafeHandle
{
}


public static class VkAttachmentSampleCountInfoAMDExtensions
{

	public static VkAttachmentSampleCountInfoAMD Dereference(this VkAttachmentSampleCountInfoAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentSampleCountInfoAMD>(x.DangerousGetHandle());
}
internal class VkAttachmentSampleCountInfoAMDExterns
{
}


public struct VkAttachmentSampleCountInfoAMD
{
}

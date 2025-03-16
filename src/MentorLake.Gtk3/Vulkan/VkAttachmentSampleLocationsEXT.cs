namespace MentorLake.Vulkan;

public class VkAttachmentSampleLocationsEXTHandle : BaseSafeHandle
{
}


public static class VkAttachmentSampleLocationsEXTExtensions
{

	public static VkAttachmentSampleLocationsEXT Dereference(this VkAttachmentSampleLocationsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAttachmentSampleLocationsEXT>(x.DangerousGetHandle());
}
internal class VkAttachmentSampleLocationsEXTExterns
{
}

public struct VkAttachmentSampleLocationsEXT
{
}

namespace MentorLake.Vulkan;


public class VkOutOfBandQueueTypeInfoNVHandle : BaseSafeHandle
{
}


public static class VkOutOfBandQueueTypeInfoNVExtensions
{

	public static VkOutOfBandQueueTypeInfoNV Dereference(this VkOutOfBandQueueTypeInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOutOfBandQueueTypeInfoNV>(x.DangerousGetHandle());
}
internal class VkOutOfBandQueueTypeInfoNVExterns
{
}


public struct VkOutOfBandQueueTypeInfoNV
{
}

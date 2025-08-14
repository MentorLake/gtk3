namespace MentorLake.Vulkan;


public class VkOutOfBandQueueTypeNVHandle : BaseSafeHandle
{
}


public static class VkOutOfBandQueueTypeNVExtensions
{

	public static VkOutOfBandQueueTypeNV Dereference(this VkOutOfBandQueueTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOutOfBandQueueTypeNV>(x.DangerousGetHandle());
}
internal class VkOutOfBandQueueTypeNVExterns
{
}


public struct VkOutOfBandQueueTypeNV
{
}

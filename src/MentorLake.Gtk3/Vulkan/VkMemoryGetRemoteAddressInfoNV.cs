namespace MentorLake.Vulkan;


public class VkMemoryGetRemoteAddressInfoNVHandle : BaseSafeHandle
{
}


public static class VkMemoryGetRemoteAddressInfoNVExtensions
{

	public static VkMemoryGetRemoteAddressInfoNV Dereference(this VkMemoryGetRemoteAddressInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryGetRemoteAddressInfoNV>(x.DangerousGetHandle());
}
internal class VkMemoryGetRemoteAddressInfoNVExterns
{
}


public struct VkMemoryGetRemoteAddressInfoNV
{
}

namespace MentorLake.Vulkan;

public class VkRemoteAddressNVHandle : BaseSafeHandle
{
}


public static class VkRemoteAddressNVExtensions
{

	public static VkRemoteAddressNV Dereference(this VkRemoteAddressNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRemoteAddressNV>(x.DangerousGetHandle());
}
internal class VkRemoteAddressNVExterns
{
}

public struct VkRemoteAddressNV
{
}

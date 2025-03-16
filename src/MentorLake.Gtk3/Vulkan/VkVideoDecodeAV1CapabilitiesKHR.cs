namespace MentorLake.Vulkan;

public class VkVideoDecodeAV1CapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeAV1CapabilitiesKHRExtensions
{

	public static VkVideoDecodeAV1CapabilitiesKHR Dereference(this VkVideoDecodeAV1CapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeAV1CapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeAV1CapabilitiesKHRExterns
{
}

public struct VkVideoDecodeAV1CapabilitiesKHR
{
}

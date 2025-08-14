namespace MentorLake.Vulkan;


public class VkVideoDecodeH264CapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH264CapabilitiesKHRExtensions
{

	public static VkVideoDecodeH264CapabilitiesKHR Dereference(this VkVideoDecodeH264CapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH264CapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH264CapabilitiesKHRExterns
{
}


public struct VkVideoDecodeH264CapabilitiesKHR
{
}

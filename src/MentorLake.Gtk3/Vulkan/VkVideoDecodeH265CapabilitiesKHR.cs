namespace MentorLake.Vulkan;

public class VkVideoDecodeH265CapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH265CapabilitiesKHRExtensions
{

	public static VkVideoDecodeH265CapabilitiesKHR Dereference(this VkVideoDecodeH265CapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH265CapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH265CapabilitiesKHRExterns
{
}

public struct VkVideoDecodeH265CapabilitiesKHR
{
}

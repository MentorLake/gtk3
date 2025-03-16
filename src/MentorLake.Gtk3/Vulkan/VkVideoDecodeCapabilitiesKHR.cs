namespace MentorLake.Vulkan;

public class VkVideoDecodeCapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeCapabilitiesKHRExtensions
{

	public static VkVideoDecodeCapabilitiesKHR Dereference(this VkVideoDecodeCapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeCapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeCapabilitiesKHRExterns
{
}

public struct VkVideoDecodeCapabilitiesKHR
{
}

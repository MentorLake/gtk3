namespace MentorLake.Vulkan;

public class VkVideoDecodeCapabilityFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeCapabilityFlagBitsKHRExtensions
{

	public static VkVideoDecodeCapabilityFlagBitsKHR Dereference(this VkVideoDecodeCapabilityFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeCapabilityFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeCapabilityFlagBitsKHRExterns
{
}

public struct VkVideoDecodeCapabilityFlagBitsKHR
{
}

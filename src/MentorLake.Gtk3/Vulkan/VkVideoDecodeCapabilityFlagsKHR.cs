namespace MentorLake.Vulkan;


public class VkVideoDecodeCapabilityFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeCapabilityFlagsKHRExtensions
{

	public static VkVideoDecodeCapabilityFlagsKHR Dereference(this VkVideoDecodeCapabilityFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeCapabilityFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeCapabilityFlagsKHRExterns
{
}


public struct VkVideoDecodeCapabilityFlagsKHR
{
}

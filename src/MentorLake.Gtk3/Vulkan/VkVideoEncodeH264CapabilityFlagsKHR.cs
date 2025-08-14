namespace MentorLake.Vulkan;


public class VkVideoEncodeH264CapabilityFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264CapabilityFlagsKHRExtensions
{

	public static VkVideoEncodeH264CapabilityFlagsKHR Dereference(this VkVideoEncodeH264CapabilityFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264CapabilityFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264CapabilityFlagsKHRExterns
{
}


public struct VkVideoEncodeH264CapabilityFlagsKHR
{
}

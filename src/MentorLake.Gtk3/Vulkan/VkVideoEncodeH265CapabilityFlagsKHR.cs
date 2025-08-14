namespace MentorLake.Vulkan;


public class VkVideoEncodeH265CapabilityFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265CapabilityFlagsKHRExtensions
{

	public static VkVideoEncodeH265CapabilityFlagsKHR Dereference(this VkVideoEncodeH265CapabilityFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265CapabilityFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265CapabilityFlagsKHRExterns
{
}


public struct VkVideoEncodeH265CapabilityFlagsKHR
{
}

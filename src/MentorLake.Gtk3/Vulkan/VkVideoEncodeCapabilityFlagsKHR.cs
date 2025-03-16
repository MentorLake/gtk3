namespace MentorLake.Vulkan;

public class VkVideoEncodeCapabilityFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeCapabilityFlagsKHRExtensions
{

	public static VkVideoEncodeCapabilityFlagsKHR Dereference(this VkVideoEncodeCapabilityFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeCapabilityFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeCapabilityFlagsKHRExterns
{
}

public struct VkVideoEncodeCapabilityFlagsKHR
{
}

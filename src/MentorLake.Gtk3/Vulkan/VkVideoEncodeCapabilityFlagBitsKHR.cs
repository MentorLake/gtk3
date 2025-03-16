namespace MentorLake.Vulkan;

public class VkVideoEncodeCapabilityFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeCapabilityFlagBitsKHRExtensions
{

	public static VkVideoEncodeCapabilityFlagBitsKHR Dereference(this VkVideoEncodeCapabilityFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeCapabilityFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeCapabilityFlagBitsKHRExterns
{
}

public struct VkVideoEncodeCapabilityFlagBitsKHR
{
}

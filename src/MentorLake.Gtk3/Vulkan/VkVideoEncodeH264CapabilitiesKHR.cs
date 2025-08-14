namespace MentorLake.Vulkan;


public class VkVideoEncodeH264CapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264CapabilitiesKHRExtensions
{

	public static VkVideoEncodeH264CapabilitiesKHR Dereference(this VkVideoEncodeH264CapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264CapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264CapabilitiesKHRExterns
{
}


public struct VkVideoEncodeH264CapabilitiesKHR
{
}

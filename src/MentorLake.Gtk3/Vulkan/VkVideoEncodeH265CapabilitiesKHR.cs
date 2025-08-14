namespace MentorLake.Vulkan;


public class VkVideoEncodeH265CapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265CapabilitiesKHRExtensions
{

	public static VkVideoEncodeH265CapabilitiesKHR Dereference(this VkVideoEncodeH265CapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265CapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265CapabilitiesKHRExterns
{
}


public struct VkVideoEncodeH265CapabilitiesKHR
{
}

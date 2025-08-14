namespace MentorLake.Vulkan;


public class VkVideoEncodeCapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeCapabilitiesKHRExtensions
{

	public static VkVideoEncodeCapabilitiesKHR Dereference(this VkVideoEncodeCapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeCapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeCapabilitiesKHRExterns
{
}


public struct VkVideoEncodeCapabilitiesKHR
{
}

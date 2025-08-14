namespace MentorLake.Vulkan;


public class VkResolveModeFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkResolveModeFlagBitsKHRExtensions
{

	public static VkResolveModeFlagBitsKHR Dereference(this VkResolveModeFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkResolveModeFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkResolveModeFlagBitsKHRExterns
{
}


public struct VkResolveModeFlagBitsKHR
{
}

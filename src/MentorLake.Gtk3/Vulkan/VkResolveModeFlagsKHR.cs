namespace MentorLake.Vulkan;


public class VkResolveModeFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkResolveModeFlagsKHRExtensions
{

	public static VkResolveModeFlagsKHR Dereference(this VkResolveModeFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkResolveModeFlagsKHR>(x.DangerousGetHandle());
}
internal class VkResolveModeFlagsKHRExterns
{
}


public struct VkResolveModeFlagsKHR
{
}

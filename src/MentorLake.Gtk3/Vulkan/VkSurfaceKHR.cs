namespace MentorLake.Vulkan;


public class VkSurfaceKHRHandle : BaseSafeHandle
{
}


public static class VkSurfaceKHRExtensions
{

	public static VkSurfaceKHR Dereference(this VkSurfaceKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceKHR>(x.DangerousGetHandle());
}
internal class VkSurfaceKHRExterns
{
}


public struct VkSurfaceKHR
{
}

namespace MentorLake.Vulkan;


public class VkSurfaceFormat2KHRHandle : BaseSafeHandle
{
}


public static class VkSurfaceFormat2KHRExtensions
{

	public static VkSurfaceFormat2KHR Dereference(this VkSurfaceFormat2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceFormat2KHR>(x.DangerousGetHandle());
}
internal class VkSurfaceFormat2KHRExterns
{
}


public struct VkSurfaceFormat2KHR
{
}

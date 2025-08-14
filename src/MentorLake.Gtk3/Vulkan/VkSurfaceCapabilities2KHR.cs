namespace MentorLake.Vulkan;


public class VkSurfaceCapabilities2KHRHandle : BaseSafeHandle
{
}


public static class VkSurfaceCapabilities2KHRExtensions
{

	public static VkSurfaceCapabilities2KHR Dereference(this VkSurfaceCapabilities2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceCapabilities2KHR>(x.DangerousGetHandle());
}
internal class VkSurfaceCapabilities2KHRExterns
{
}


public struct VkSurfaceCapabilities2KHR
{
}

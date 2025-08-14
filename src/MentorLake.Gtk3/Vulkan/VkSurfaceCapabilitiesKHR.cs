namespace MentorLake.Vulkan;


public class VkSurfaceCapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkSurfaceCapabilitiesKHRExtensions
{

	public static VkSurfaceCapabilitiesKHR Dereference(this VkSurfaceCapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceCapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkSurfaceCapabilitiesKHRExterns
{
}


public struct VkSurfaceCapabilitiesKHR
{
}

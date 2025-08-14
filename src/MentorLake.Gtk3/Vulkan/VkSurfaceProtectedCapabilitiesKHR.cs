namespace MentorLake.Vulkan;


public class VkSurfaceProtectedCapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkSurfaceProtectedCapabilitiesKHRExtensions
{

	public static VkSurfaceProtectedCapabilitiesKHR Dereference(this VkSurfaceProtectedCapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceProtectedCapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkSurfaceProtectedCapabilitiesKHRExterns
{
}


public struct VkSurfaceProtectedCapabilitiesKHR
{
}

namespace MentorLake.Vulkan;


public class VkSharedPresentSurfaceCapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkSharedPresentSurfaceCapabilitiesKHRExtensions
{

	public static VkSharedPresentSurfaceCapabilitiesKHR Dereference(this VkSharedPresentSurfaceCapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSharedPresentSurfaceCapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkSharedPresentSurfaceCapabilitiesKHRExterns
{
}


public struct VkSharedPresentSurfaceCapabilitiesKHR
{
}

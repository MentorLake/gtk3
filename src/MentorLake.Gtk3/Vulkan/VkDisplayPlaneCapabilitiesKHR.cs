namespace MentorLake.Vulkan;

public class VkDisplayPlaneCapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayPlaneCapabilitiesKHRExtensions
{

	public static VkDisplayPlaneCapabilitiesKHR Dereference(this VkDisplayPlaneCapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPlaneCapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkDisplayPlaneCapabilitiesKHRExterns
{
}

public struct VkDisplayPlaneCapabilitiesKHR
{
}

namespace MentorLake.Vulkan;


public class VkDisplayPlaneCapabilities2KHRHandle : BaseSafeHandle
{
}


public static class VkDisplayPlaneCapabilities2KHRExtensions
{

	public static VkDisplayPlaneCapabilities2KHR Dereference(this VkDisplayPlaneCapabilities2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPlaneCapabilities2KHR>(x.DangerousGetHandle());
}
internal class VkDisplayPlaneCapabilities2KHRExterns
{
}


public struct VkDisplayPlaneCapabilities2KHR
{
}

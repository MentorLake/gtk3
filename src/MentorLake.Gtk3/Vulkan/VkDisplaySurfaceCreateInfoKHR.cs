namespace MentorLake.Vulkan;

public class VkDisplaySurfaceCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDisplaySurfaceCreateInfoKHRExtensions
{

	public static VkDisplaySurfaceCreateInfoKHR Dereference(this VkDisplaySurfaceCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplaySurfaceCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkDisplaySurfaceCreateInfoKHRExterns
{
}

public struct VkDisplaySurfaceCreateInfoKHR
{
}

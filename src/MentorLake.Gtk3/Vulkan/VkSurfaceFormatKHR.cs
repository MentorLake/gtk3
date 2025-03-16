namespace MentorLake.Vulkan;

public class VkSurfaceFormatKHRHandle : BaseSafeHandle
{
}


public static class VkSurfaceFormatKHRExtensions
{

	public static VkSurfaceFormatKHR Dereference(this VkSurfaceFormatKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceFormatKHR>(x.DangerousGetHandle());
}
internal class VkSurfaceFormatKHRExterns
{
}

public struct VkSurfaceFormatKHR
{
}

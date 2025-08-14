namespace MentorLake.Vulkan;


public class VkDisplaySurfaceCreateFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkDisplaySurfaceCreateFlagsKHRExtensions
{

	public static VkDisplaySurfaceCreateFlagsKHR Dereference(this VkDisplaySurfaceCreateFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplaySurfaceCreateFlagsKHR>(x.DangerousGetHandle());
}
internal class VkDisplaySurfaceCreateFlagsKHRExterns
{
}


public struct VkDisplaySurfaceCreateFlagsKHR
{
}

namespace MentorLake.Vulkan;


public class VkBindImagePlaneMemoryInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBindImagePlaneMemoryInfoKHRExtensions
{

	public static VkBindImagePlaneMemoryInfoKHR Dereference(this VkBindImagePlaneMemoryInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindImagePlaneMemoryInfoKHR>(x.DangerousGetHandle());
}
internal class VkBindImagePlaneMemoryInfoKHRExterns
{
}


public struct VkBindImagePlaneMemoryInfoKHR
{
}
